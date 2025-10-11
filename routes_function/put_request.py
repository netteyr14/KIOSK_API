from flask import jsonify, request
from db.db_connections import init_db_pool

# DB CONNECTION
pool = init_db_pool()
if pool is not None:
    print("[INFO] Database pool created successfully! - put_request.py")
else:
    print("[ERROR] Database pool creation failed! - put_request.py")
#EXECUTE UPDATE
def execute_query(query, params=None):  
    conn = pool.get_connection()
    cursor = conn.cursor(dictionary=True)
    try:
        cursor.execute(query, params or ())
        conn.commit() 
        return {"status": "success", "message": "Updated Successfully"}
    except Exception as e:
        conn.rollback()
        return {"error": str(e)}
    finally:
        cursor.close()
        conn.close()

#===============PUT=================#
def put_student_management(student_info=None):
    sql = """UPDATE tbl_student SET
    rfid_card = %s,
    fname = %s,
    mname = %s,
    lname = %s,
    course_no = %s,
    year_level = %s,
    section = %s,
    isactive = %s,
    image_path = %s
    WHERE stud_number = %s"""

    params = (
        student_info["rfid"],
        student_info["fname"],
        student_info["mname"],
        student_info["lname"],
        student_info["course_no"],
        student_info["year_level"],
        student_info["section"],
        student_info["isactive"],
        student_info["image_path"],
        student_info["stud_num"]
    )

    data = execute_query(sql, params)
    return jsonify(data)