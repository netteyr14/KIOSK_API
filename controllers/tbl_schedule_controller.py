from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one, execute_query

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None, deleted=None):
    allowed_tables = ["tbl_schedule"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["schedule_id", "student_no", "subject_no", "day_of_week", "time_start", "time_end", "room", "faculty_no", "isdeleted"]
    if order_by and order_by not in allowed_columns:
        return jsonify({"error": "Invalid order column"}), 400

    sql = f"SELECT * FROM {table_name} WHERE 1=1"
    params = []

    if deleted is not None:
        sql += " AND isdeleted = %s"
        params.append(deleted)

    if search:
        sql += """ AND (
                schedule_id LIKE %s OR 
                student_no LIKE %s OR
                subject_no LIKE %s OR 
                day_of_week LIKE %s OR
                time_start LIKE %s OR
                time_end LIKE %s OR
                room LIKE %s OR
                faculty_no LIKE %s OR
                isdeleted LIKE %s)
        """
        search_param = f"%{search}%"
        params += [search_param] * 9

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["schedule_id", "student_no", "subject_no", "day_of_week", "time_start", "time_end", "room", "faculty_no", "isdeleted"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)

#===============POST/INSERT=================#

def post(schedule_info=None):
    sql = """INSERT INTO tbl_schedule
    (student_no, subject_no, day_of_week, time_start, time_end, room, faculty_no)
    VALUES
    (%s,%s,%s,%s,%s,%s,%s)"""

    params = (
        schedule_info["student_no"],
        schedule_info["subject_no"],
        schedule_info["day_of_week"],
        schedule_info["time_start"],
        schedule_info["time_end"],
        schedule_info["room"],
        schedule_info["faculty_no"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============PUT/UPDATE=================#
def put(schedule_info=None):
    sql = """UPDATE tbl_schedule SET
    student_no = %s,
    subject_no = %s,
    day_of_week = %s,
    time_start = %s,
    time_end = %s,
    room = %s,
    faculty_no = %s
    WHERE schedule_id = %s"""

    params = (
        schedule_info["student_no"],
        schedule_info["subject_no"],
        schedule_info["day_of_week"],
        schedule_info["time_start"],
        schedule_info["time_end"],
        schedule_info["room"],
        schedule_info["faculty_no"],
        schedule_info["schedule_id"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============DELETE=================#
def delete(schedule_info):
    schedule_id = schedule_info.get("schedule_id")
    sql = f"UPDATE tbl_schedule SET isdeleted = 1 WHERE schedule_id = %s"
    data = execute_query(sql, (schedule_id,))
    return jsonify(data)

#==============RESTORE=================#
def restore(schedule_info):
    schedule_id = schedule_info.get("schedule_id")
    sql = f"UPDATE tbl_schedule SET isdeleted = 0 WHERE schedule_id = %s"
    data = execute_query(sql, (schedule_id,))
    return jsonify(data)