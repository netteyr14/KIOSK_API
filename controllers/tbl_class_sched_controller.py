from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one, execute_query

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None):
    allowed_tables = ["tbl_class_sched"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["class_sched_id", "year_level", "image_path"]
    if order_by and order_by not in allowed_columns:
        return jsonify({"error": "Invalid order column"}), 400

    sql = f"SELECT * FROM {table_name} WHERE 1=1"
    params = []

    # if deleted is not None:
    #     sql += " AND isdeleted = %s"
    #     params.append(deleted)

    if search:
        sql += """ AND (
                class_sched_id LIKE %s OR 
                year_level LIKE %s OR
                image_path LIKE %s
        """
        search_param = f"%{search}%"
        params += [search_param] * 3

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["class_sched_id", "year_level", "image_path"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)

#===============POST/INSERT=================#

def post(class_sched_info=None):
    sql = """INSERT INTO tbl_class_sched
    (year_level, image_path)
    VALUES
    (%s,%s)"""

    params = (
        class_sched_info["year_level"],
        class_sched_info["image_path"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============PUT/UPDATE=================#
def put(class_sched_info=None):
    sql = """UPDATE tbl_class_sched SET
    year_level = %s,
    image_path = %s
    WHERE class_sched_id = %s"""

    params = (
        class_sched_info['year_level'],
        class_sched_info['image_path'],
        class_sched_info['class_sched_id']
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