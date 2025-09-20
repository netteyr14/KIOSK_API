from flask import jsonify, request
from db.db_connections import init_db_pool

# DB CONNECTION
pool = init_db_pool()
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
        return {"message": "Added Successfully"}
    except Exception as e:
        conn.rollback()
        return {"error": str(e)}
    finally:
        cursor.close()
        conn.close()

#===============POST=================#

def post_student_management(student_info=None):
    sql = """INSERT INTO tbl_student
    (stud_number, rfid_card, fname, mname, lname, course_no, section, year_level, isactive, isdeleted)
    VALUES
    (%s,%s,%s,%s,%s,%s,%s,%s,%s,%s)"""

    params = (
        student_info["stud_number"],
        student_info["rfid_card"],
        student_info["fname"],
        student_info["mname"],
        student_info["lname"],
        student_info["course_no"],
        student_info["section"],
        student_info["year_level"],
        student_info["isactive"],
        student_info["isdeleted"]
    )

    data = execute_query(sql, params)
    return jsonify(data)