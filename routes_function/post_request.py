from flask import jsonify, request
from db.db_connections import pool

if pool is not None:
    print("[INFO] Database pool created successfully! - post_request.py")
else:
    print("[ERROR] Database pool creation failed! - post_request.py")
# EXECUTE INSERT
def execute_query(query, params=None):  
    conn = pool.get_connection()
    cursor = conn.cursor(dictionary=True)
    try:
        cursor.execute(query, params or ())
        conn.commit() 
        return {"status": "success", "message": "Added Successfully"}
    except Exception as e:
        conn.rollback()
        return {"message": str(e)}
    finally:
        cursor.close()
        conn.close()

#===============STUDENT=================#

def post_student_management(student_info=None):
    sql = """INSERT INTO tbl_student
    (stud_number, rfid_card, fname, mname, lname, course_no, year_level, section, isactive, img_path)
    VALUES
    (%s,%s,%s,%s,%s,%s,%s,%s,%s,%s)"""

    params = (
        student_info["stud_num"],
        student_info["rfid"],
        student_info["fname"],
        student_info["mname"],
        student_info["lname"],
        student_info["course_no"],
        student_info["year_level"],
        student_info["section"],
        student_info["isactive"],
        student_info["img_path"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============LOSTFOUND=================#

def post_lostfound_info(lostfound_info=None):
    sql = """INSERT INTO tbl_lostfound
    (item_name, description, reported_by, reported_at, status, image_path)
    VALUES
    (%s,%s,%s,%s,%s,%s)"""

    params = (
        lostfound_info["item_name"],
        lostfound_info["description"],
        lostfound_info["reported_by"],
        lostfound_info["reported_at"],
        lostfound_info["status"],
        lostfound_info["image_path"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============COURSE-MAINTENANCE=================#

def post_course_information(course_info=None):
    sql = """INSERT INTO tbl_course
    (course_name, course_code)
    VALUES
    (%s,%s)"""

    params = (
        course_info["course_name"],
        course_info["course_code"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============FACULTY-MAINTENANCE=================#
def post_faculty_information(faculty_info=None):
    sql = """INSERT INTO tbl_faculty
    (first_name, middle_name, last_name)
    VALUES
    (%s,%s)"""

    params = (
        faculty_info["first_name"],
        faculty_info["middle_name"],
        faculty_info["last_name"]
    )
    data = execute_query(sql, params)
    return jsonify(data)

#===============SUBJECT-MAINTENANCE=================#
def post_subject_information(subject_info=None):
    sql = """INSERT INTO tbl_subject
    (subject_code, subject_name)
    VALUES
    (%s,%s,%s,%s,%s)"""

    params = (
        subject_info["subject_code"],
        subject_info["subject_name"],
    )
    data = execute_query(sql, params)
    return jsonify(data)

