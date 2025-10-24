from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one, execute_query

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None, deleted=None):
    allowed_tables = ["tbl_course"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["course_id", "course_code", "course_name", "isdeleted"]
    if order_by and order_by not in allowed_columns:
        return jsonify({"error": "Invalid order column"}), 400

    sql = f"SELECT * FROM {table_name} WHERE 1=1"
    params = []

    if deleted is not None:
        sql += " AND isdeleted = %s"
        params.append(deleted)

    if search:
        sql += """ AND (
                course_id LIKE %s OR 
                course_code LIKE %s OR
                course_name LIKE %s OR 
                isdeleted LIKE %s)
        """
        search_param = f"%{search}%"
        params += [search_param] * 4

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["course_id", "course_code", "course_name", "isdeleted"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)

#===============POST/INSERT=================#

def post(course_info=None):
    sql = """INSERT INTO tbl_course
    (course_code, course_name)
    VALUES
    (%s,%s)"""

    params = (
        course_info["course_code"],
        course_info["course_name"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============PUT/UPDATE=================#
def put(course_info=None):
    sql = """UPDATE tbl_course SET
    course_code = %s,
    course_name = %s
    WHERE course_id = %s"""

    params = (
        course_info["course_code"],
        course_info["course_name"],
        course_info["course_id"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============DELETE=================#
def delete(course_info):
    course_id = course_info.get("course_id")
    sql = f"UPDATE tbl_course SET isdeleted = 1 WHERE course_id = %s"
    data = execute_query(sql, (course_id,))
    return jsonify(data)

#==============RESTORE=================#
def restore(course_info):
    course_id = course_info.get("course_id")
    sql = f"UPDATE tbl_course SET isdeleted = 0 WHERE course_id = %s"
    data = execute_query(sql, (course_id,))
    return jsonify(data)