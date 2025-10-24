from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one, execute_query

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None, deleted=None):
    allowed_tables = ["tbl_admin"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["admin_id", "fullname", "uname", "pword", "role", "isactive", "isdeleted", "created_at"]
    if order_by and order_by not in allowed_columns:
        return jsonify({"error": "Invalid order column"}), 400

    sql = f"SELECT * FROM {table_name} WHERE 1=1"
    params = []

    if deleted is not None:
        sql += " AND isdeleted = %s"
        params.append(deleted)

    if search:
        sql += """ AND (
                admin_id LIKE %s OR 
                fullname LIKE %s OR
                uname LIKE %s OR 
                pword LIKE %s OR
                role LIKE %s OR
                isactive LIKE %s OR
                isdeleted LIKE %s OR
                created_at LIKE %s)
        """
        search_param = f"%{search}%"
        params += [search_param] * 6

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["admin_id", "fullname", "uname", "pword", "role", "isactive", "isdeleted", "created_at"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)

#===============POST/INSERT=================#

def post(faculty_info=None):
    sql = """INSERT INTO tbl_admin
    (fullname, uname, pword, role, isactive, isdeleted)
    VALUES
    (%s,%s,%s,%s,%s,%s)"""

    params = (
        faculty_info["fullname"],
        faculty_info["uname"],
        faculty_info["pword"],
        faculty_info["role"],
        faculty_info["isactive"],
        faculty_info["isdeleted"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============PUT/UPDATE=================#
def put(admin_info=None):
    sql = """UPDATE tbl_admin SET
    fullname = %s,
    uname = %s,
    pword = %s,
    role = %s,
    isactive = %s
    WHERE admin_id = %s"""

    params = (
        admin_info["fullname"],
        admin_info["uname"],
        admin_info["pword"],
        admin_info["role"],
        admin_info["isactive"],
        admin_info["admin_id"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============DELETE=================#
def delete(admin_info):
    admin_id = admin_info.get("admin_id")
    sql = f"UPDATE tbl_admin SET isdeleted = 1 WHERE admin_id = %s"
    data = execute_query(sql, (admin_id,))
    return jsonify(data)

#===============RESTORE=================#
def restore(admin_info):
    admin_id = admin_info.get("admin_id")
    sql = f"UPDATE tbl_admin SET isdeleted = 0 WHERE admin_id = %s"
    data = execute_query(sql, (admin_id,))
    return jsonify(data)