from flask import jsonify
from datetime import timedelta 
from db.db_connections import init_db_pool

# DB CONNECTION
pool = init_db_pool()
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

#===============GET=================#

#LOAD STUDENT MANAGEMENT TABLE TO
def get_tbl_student_management(search=None, selection=None):
    sql = f"""SELECT 
                stud_number, 
                rfid_card, 
                fname, 
                mname, 
                lname, 
                course_name, 
                year_level, 
                section, 
                isactive 
            FROM vw_students 
            WHERE 1=1 """
    params = []

    if selection:
        sql += " AND (course_name = %s OR year_level = %s)"
        params += [selection] * 2

    if search:
        sql += """ 
            AND (
                stud_number LIKE %s OR 
                fname LIKE %s OR 
                mname LIKE %s OR 
                lname LIKE %s OR 
                course_name LIKE %s
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

def get_course_name():
    sql = "SELECT course_name, course_id FROM tbl_course"
    rows = fetch_all(sql) 
    return jsonify(rows)
