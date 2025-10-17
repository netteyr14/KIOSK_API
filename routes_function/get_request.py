from flask import jsonify
from datetime import timedelta 
from db.db_connections import pool

if pool is not None:
    print("[INFO] Database pool created successfully! - get_request.py")
else:
    print("[ERROR] Database pool creation failed! - get_request.py")
#FETCH TABLE
def fetch_all(query, params=None):
    conn = pool.get_connection()
    cursor = conn.cursor(dictionary=True)

    try:
        cursor.execute(query, params or ())
        return cursor.fetchall()
    finally:
        cursor.close()
        conn.close()

def fetch_one(query, params=None):
    conn = pool.get_connection()
    cursor = conn.cursor(dictionary=True, buffered=True)

    try:
        cursor.execute(query, params or ())
        return cursor.fetchone()
    finally:
        cursor.close()
        conn.close()

#===============STUDENT=================#

#LOAD STUDENT MANAGEMENT TABLE TO
def get_tbl_student_management(search=None, selection=None):
    sql = """SELECT 
                stud_number, 
                rfid_card, 
                fname, 
                mname, 
                lname, 
                course_code, 
                year_level, 
                section, 
                isactive 
            FROM vw_students 
            WHERE 1=1 AND isdeleted = 0"""  # WHERE 1=1 is purely for conventional writting lang para di na lagi i type yung WHERE clause keyword
    params = []

    if selection:
        sql += " AND (course_code = %s OR year_level = %s)"
        params += [selection] * 2

    if search:
        sql += """ 
            AND (
                stud_number LIKE %s OR 
                fname LIKE %s OR 
                mname LIKE %s OR 
                lname LIKE %s OR 
                course_code LIKE %s
            )
        """
        search_param = f"%{search}%"    #left and right matching
        params += [search_param] * 5     #pasa yung search_param then multiply 5 kasi lima yung search fields
    data = fetch_all(sql, params)
    return jsonify(data)

#LOAD CLASS SCHED TABLE TO
def get_tbl_class_sched(student_number=None):
    sql = """
        SELECT 
            subject_name, 
            CONCAT(faculty_fname, " ", faculty_lname) AS f_fullname, 
            day_of_week, time_start, time_end, room
        FROM vw_schedules
        WHERE 1=1 """# WHERE 1=1 is purely for conventional writting lang para di na lagi i type yung WHERE clause keyword
    params = []

    if student_number:
        sql += " AND stud_number = %s"
        params.append(student_number)

    # fetch_all handles DB connection and executes safely
    data = fetch_all(sql, params)  
    # Convert any timedelta fields to string
    for row in data:
        if isinstance(row.get("time_start"), timedelta):
            row["time_start"] = str(row["time_start"])
        if isinstance(row.get("time_end"), timedelta):
            row["time_end"] = str(row["time_end"])
    return jsonify(data)

def get_course_cbo():
    sql = "SELECT course_code, course_id FROM tbl_course ORDER BY course_id ASC"
    rows = fetch_all(sql) 
    return jsonify(rows)

def get_a_column_for_student_management(stud_num=None, sql=None): 
    params = []
    if stud_num:
        sql += " WHERE stud_number = %s"
        params.append(stud_num)
    rows = fetch_one(sql, params)
    return jsonify(rows)


#===============LOSTFOUND=================#

def get_tbl_lost_and_found(item_name=None, status=None):
    sql = """SELECT 
                lostfound_id,
                item_name,
                description,
                image_path,
                status,
                reported_by,
                reported_at,
                claimed_by,
                claimed_at
            FROM tbl_lostfound
            WHERE 1=1"""
    
    params = []

    if status:
        sql += " AND (course_code = %s OR year_level = %s)"
        params += [status] * 2

    if item_name:
        sql += """ 
            AND (
                stud_number LIKE %s OR 
                fname LIKE %s OR 
                mname LIKE %s OR 
                lname LIKE %s OR 
                course_code LIKE %s
            )
        """
        search_param = f"%{item_name}%"    #left and right matching
        params += [search_param] * 5     #pasa yung search_param then multiply 5 kasi lima yung search fields
    data = fetch_all(sql, params)
    return jsonify(data)

def get_a_column_for_lostfound(lostfound_id=None, sql=None): 
    params = []
    if lostfound_id:
        sql += " WHERE lostfound_id = %s"
        params.append(lostfound_id)
    rows = fetch_one(sql, params)
    return jsonify(rows)

#===============COURSE-MAINTENANCE=================#
def get_course_dgv():
    sql = "SELECT course_id, course_name, course_code FROM tbl_course"
    rows = fetch_all(sql) 
    return jsonify(rows)
def serial_num(received_rfid, ser):
    sql = "select student_id from tbl_student where rfid_Card = %s and isdeleted = 0 limit 1"
    
    fetch_one(sql, received_rfid)
