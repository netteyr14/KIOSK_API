from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one, execute_query

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None, deleted=None):
    allowed_tables = ["tbl_faculty"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["faculty_id", "fname", "mname", "lname", "isactive", "isdeleted"]
    if order_by and order_by not in allowed_columns:
        return jsonify({"error": "Invalid order column"}), 400

    sql = f"SELECT * FROM {table_name} WHERE 1=1"
    params = []

    if deleted is not None:
        sql += " AND isdeleted = %s"
        params.append(deleted)

    if search:
        sql += """ AND (
                faculty_id LIKE %s OR 
                fname LIKE %s OR
                mname LIKE %s OR 
                lname LIKE %s OR
                isactive LIKE %s OR
                isdeleted LIKE %s)
        """
        search_param = f"%{search}%"
        params += [search_param] * 6

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["faculty_id", "fname", "mname", "lname", "isactive", "isdeleted"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)

#===============POST/INSERT=================#

def post(faculty_info=None):
    sql = """INSERT INTO tbl_faculty
    (fname, mname, lname, isactive)
    VALUES
    (%s,%s,%s,%s)"""

    params = (
        faculty_info["fname"],
        faculty_info["mname"],
        faculty_info["lname"],
        faculty_info["isactive"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============PUT/UPDATE=================#
def put(faculty_info=None):
    sql = """UPDATE tbl_faculty SET
    course_code = %s,
    course_name = %s
    WHERE faculty_id = %s"""

    params = (
        faculty_info["fname"],
        faculty_info["mname"],
        faculty_info["lname"],
        faculty_info["isactive"],
        faculty_info["faculty_id"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============DELETE=================#
def delete(faculty_info):
    faculty_id = faculty_info.get("faculty_id")
    sql = f"UPDATE tbl_faculty SET isdeleted = 1 WHERE course_id = %s"
    data = execute_query(sql, (faculty_id,))
    return jsonify(data)

#===============DELETE=================#
def delete(faculty_info):
    faculty_id = faculty_info.get("faculty_id")
    sql = f"UPDATE tbl_faculty SET isdeleted = 0 WHERE course_id = %s"
    data = execute_query(sql, (faculty_id,))
    return jsonify(data)