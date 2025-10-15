from flask import jsonify, request
from db.db_connections import init_db_pool

# DB CONNECTION
pool = init_db_pool()
if pool is not None:
    print("[INFO] Database pool created successfully! - del_request.py")
else:
    print("[ERROR] Database pool creation failed! - del_request.py")

#EXECUTE DELETE
def execute_query(query, params=None):
    conn = pool.get_connection()
    cursor = conn.cursor(dictionary=True)
    try:
        cursor.execute(query, params or ())
        conn.commit() 
        return {"status": "success", "message": "Deleted Successfully"}
    except Exception as e:
        conn.rollback()
        return {"error": str(e)}
    finally:
        cursor.close()
        conn.close()

#===============STUDENT=================#
def del_student_management(student_info):
    stud_num = student_info.get("stud_num")
    sql = f"UPDATE tbl_student SET isdeleted = 1 WHERE stud_number = %s"
    data = execute_query(sql, (stud_num,))
    return jsonify(data)

#===============LOSTFOUND=================#
def del_lostfound_info(lostfound_info):
    lostfound_id = lostfound_info.get("lostfound_id")
    sql = f"DELETE FROM tbl_lostfound WHERE lostfound_id = %s"
    data = execute_query(sql, (lostfound_id,))
    return jsonify(data)

#===============COURSE-MAINTENANCE=================#
def del_course_information(course_info):
    course_id = course_info.get("course_id")
    sql = f"DELETE FROM tbl_course WHERE course_id = %s"
    data = execute_query(sql, (course_id,))
    return jsonify(data)