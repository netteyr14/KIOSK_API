from flask import jsonify
from db.db_connections import init_db_pool_rfid

#DB CONNECTION
pool = init_db_pool_rfid()
#FETCH TABLE
def fetch_all(query, params=None):
    conn = pool.get_connection()
    cursor = conn.cursor(dictionary=True) #No need converting dicts on returns/jsonify

    try:
        cursor.execute(query, params or ())
        return cursor.fetchall()
    finally:
        cursor.close()
        conn.close()

def get_course_name():
    sql = "SELECT course_name, course_id FROM tbl_course"
    rows = fetch_all(sql) 
    return jsonify(rows) 

def get_section():
    sql = "SELECT student_section, section_id FROM tbl_section"
    rows = fetch_all(sql) 
    return jsonify(rows) 

def get_year():
    sql = "SELECT year_level, year_id FROM tbl_year"
    rows = fetch_all(sql) 
    return jsonify(rows) 