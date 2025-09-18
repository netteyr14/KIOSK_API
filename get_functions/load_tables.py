from flask import jsonify
from datetime import timedelta 
from db.db_connections import init_db_pool_rfid

#DB CONNECTION
pool = init_db_pool_rfid()
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

#===============METHODS=================#

#LOAD STUDENT MANAGEMENT TABLE TO
def get_tbl_student_management():
    sql = "SELECT stud_number, rfid_card, fname, mname, lname, course_name, year_level, student_section FROM vw_students"
    data = fetch_all(sql)
    return jsonify(data)

#LOAD CLASS SCHED TABLE TO
def get_tbl_class_sched(student_number=None):
    sql = """
        SELECT 
            subject_name, 
            CONCAT(faculty_fname, " ", faculty_lname) AS f_fullname, 
            day_of_week, time_start, time_end, room
        FROM vw_schedules
        WHERE 1=1 
    """# WHERE 1=1 is purely for conventional writting lang para di na lagi i type yung WHERE clause keyword
    params = []

    if student_number:
        sql += " AND stud_number = %s"
        params.append(student_number)

    data = fetch_all(sql, params)  # fetch_all handles DB connection and executes safely
    # Convert any timedelta fields to string
    for row in data:
        if isinstance(row.get("time_start"), timedelta):
            row["time_start"] = str(row["time_start"])
        if isinstance(row.get("time_end"), timedelta):
            row["time_end"] = str(row["time_end"])

    return data
