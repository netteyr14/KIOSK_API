from db.db_connections import pool
import serial, threading, time
from datetime import datetime

recent_inserts = {}
duplicate_window_records = 5

def find_student_by_rfid(rfid_number, conn):
    try:
        cur = conn.cursor(dictionary=True)
        sql = "select student_id, stud_number from tbl_student where rfid_card = %s and isdeleted = 0 and isactive = 1 limit 1"
        cur.execute(sql, (str(rfid_number),))
        row = cur.fetchone()
        return row['student_id']if row else None, row['stud_number'] if row else None
    except Exception as e:
        print("Error finding student: ",e)

def insert_attendance(student_id, node_no, conn):
    try:
        cur = conn.cursor()
        sql = "insert into tbl_attendance (student_no, node_no, logs)values(%s, %s, NOW())"
        cur.execute(sql, (student_id,node_no))
        conn.commit()
    except Exception as e:
        print("Error inserting attachment: ", e)

def handle_message(device_num, rfid_num):
    conn = pool.get_connection()
    if not conn:
        return
    
    try:
        student_id, student_number = find_student_by_rfid(rfid_num, conn)# for logging purposes only. needs to follow retrun order
        if not student_id:
            print(f"No student found for RFID: {rfid_num}")
            return

        cur = conn.cursor(dictionary=True)
        sql = "SELECT time_start, time_end, day_of_week, room FROM tbl_schedule WHERE student_no=%s LIMIT 1"
        cur.execute(sql, (student_id,))
        schedule = cur.fetchone()

        if not schedule:
            print(f"No schedule found for student: {student_id}")
            return

        time_start = schedule['time_start']
        time_end = schedule['time_end']
        day_of_week = schedule['day_of_week'].lower()
        room = int(schedule['room']) # INT ANG DEVICE_NUM KAYA NEED I CONVERT

        now = datetime.now()
        now_ts = time.time()
        current_day = now.strftime('%A').lower()

        last = recent_inserts.get(student_id, 0)
        if now_ts - last < duplicate_window_records:
            print(f"Ignore duplicate for student: {student_id}")
            return

        if (time_start <= now <= time_end) and (day_of_week == current_day) and (room == device_num):
            insert_attendance(student_id, device_num, conn)
            recent_inserts[student_id] = now_ts
            print(f"\nInserted attendance for student: {student_number} at node {device_num}")
        else:
            print(f"\nStudent {student_number} [RFID: {rfid_num}] is not scheduled in {room} at this time.")
            # print(f"[DEBUG]Schedule: {day_of_week} {time_start}-{time_end}, Now: {current_day} {now}, Device: {device_num}")

    except Exception as e:
        print(f"DB error handle_message:", e)
    finally:
        try:
            conn.close()
        except:
            pass
        
def serial_thread():
    while True:
        print("Starting serial thread, opening port COM7")
        ser = serial.Serial("COM7", 115200, timeout=1)
        print("Serial port opened successfully!")
        while True:
            try:
                line = ser.readline().decode('utf-8', errors='ignore').strip()
                if not line:
                    time.sleep(0.5)
                    continue
                # print(f"here1: {line}")
                parts = line.split(',')
                if len(parts) >=2:
                    try:
                        device = int(parts[0].strip())
                        rfid = parts[1].strip()
                        threading.Thread(target=handle_message, args=(device, rfid), daemon=True).start()
                    except ValueError:
                        print("Invalid device number in serial: ", parts[0])
                else:
                    print("Malformed serial line: ", line)
            except Exception as e:
                print("Serial port error: ", e)
                time

def safe_loop():
    while True:
        try:
            serial_thread()
        except Exception as e:
            print("Fatal Error in Serial thread: ", e)
            print("Restarting serial thread in 5 seconds...")
            time.sleep(5)