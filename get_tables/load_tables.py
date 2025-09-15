from flask import jsonify
from db.db_connections import init_db_pool_rfid, fetch_all

init_db_pool_rfid()

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
