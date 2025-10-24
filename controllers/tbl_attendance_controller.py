from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one, execute_query

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None):
    allowed_tables = ["tbl_attendance"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["attendance_id", "student_no", "node_no", "logs"]
    if order_by and order_by not in allowed_columns:
        return jsonify({"error": "Invalid order column"}), 400

    sql = f"SELECT * FROM {table_name} WHERE 1=1"
    params = []

    # if deleted is not None:
    #     sql += " AND isdeleted = %s"
    #     params.append(deleted)

    if search:
        sql += """ AND (
                attendance_id LIKE %s OR 
                student_no LIKE %s OR
                node_no LIKE %s OR 
                logs LIKE %s)
        """
        search_param = f"%{search}%"
        params += [search_param] * 4

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["attendance_id", "student_no", "node_no", "logs"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)

#===============POST/INSERT=================#

def post(attendance_info=None):
    sql = """INSERT INTO tbl_attendance
    (student_no, node_no, logs)
    VALUES
    (%s,%s)"""

    params = (
        attendance_info["student_no"],
        attendance_info["node_no"],
        attendance_info["logs"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============PUT/UPDATE=================#
def put(attendance_info=None):
    sql = """UPDATE tbl_attendance SET
    student_no = %s,
    node_no = %s,
    logs = %s
    WHERE attendance_id = %s"""

    params = (
        attendance_info['student_no'],
        attendance_info['node_no'],
        attendance_info['logs'],
        attendance_info['attendance_id']
    )

    data = execute_query(sql, params)
    return jsonify(data)

# #===============DELETE=================#
# def delete(attendance_info):
#     attendance_id = attendance_info.get("attendance_id")
#     sql = f"UPDATE tbl_attendance SET isdeleted = 1 WHERE attendance_id = %s"
#     data = execute_query(sql, (attendance_id,))
#     return jsonify(data)

# #===============RESTORE=================#
# def delete(attendance_info):
#     attendance_id = attendance_info.get("attendance_id")
#     sql = f"UPDATE tbl_announcement SET isdeleted = 0 WHERE attendance_id = %s"
#     data = execute_query(sql, (attendance_id,))
#     return jsonify(data)