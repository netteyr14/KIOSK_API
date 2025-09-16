from flask import jsonify
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
def tbl_student_management():
    sql = "SELECT * FROM tblsm"
    data = fetch_all(sql)
    return jsonify(data)

#LOAD CLASS SCHED TABLE TO
def tbl_class_sched():
    sql = "SELECT * FROM tblcs"
    data = fetch_all(sql)
    return jsonify(data)
