from waitress import serve
from server.init_server import create_app
import argparse, threading, time, serial
from db.db_connections import pool

recent_inserts = {}
duplicate_window_records = 5

def find_student_by_rfid(rfid_number, conn):
    try:
        cur = conn.cursor(dictionary=True)
        sql = "select student_id from tbl_student where rfid_card = %s and isdeleted = 0 and isactive = 1 limit 1"
        cur.execute(sql, (str(rfid_number),))
        row = cur.fetchone()
        return row['student_id'] if row else None
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
        student_id = find_student_by_rfid(rfid_num, conn)# 1
        if student_id:
            last = recent_inserts.get(student_id, 0)
            now_ts = time.time()
            if now_ts - last < duplicate_window_records:
                print(f"Ignore duplicate for student: {student_id}")
            else:
                insert_attendance(student_id, device_num, conn)
                recent_inserts[student_id] = now_ts
                print(f"Inserted attendance for student: {student_id} at node {device_num}")
    except Exception as e:
        print(f"DB error handled_message: ", e)
    finally:
        try:
            conn.close()
        except:
            pass
        

def serial_thread():
    while True:
        print("Starting serial thread, opening port COM6")
        ser = serial.Serial("COM6", 115200, timeout=1)
        print("Serial port opened successfully!")
        while True:
            try:
                line = ser.readline().decode('utf-8', errors='ignore').strip()
                if not line:
                    time.sleep(0.5)
                    continue
                print(f"here1: {line}")
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

app = create_app()

if __name__ == '__main__':
    parser = argparse.ArgumentParser()
    parser.add_argument("--port", type=int, default=5000)
    args = parser.parse_args()

    print(f"[INFO] Starting Waitress on port {args.port}...")
    t = threading.Thread(target=safe_loop, daemon=True)
    t.start()
    serve(app, host='localhost', port=args.port, threads=20)