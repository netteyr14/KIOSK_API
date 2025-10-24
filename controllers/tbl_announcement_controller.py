from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one, execute_query

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None, deleted=None):
    allowed_tables = ["tbl_announcement"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["announcement_id", "title", "message", "image_path", "admin_no", "created_at", "expire_at", "isdisplay", "isdeleted"]
    if order_by and order_by not in allowed_columns:
        return jsonify({"error": "Invalid order column"}), 400

    sql = f"SELECT * FROM {table_name} WHERE 1=1"
    params = []

    if deleted is not None:
        sql += " AND isdeleted = %s"
        params.append(deleted)

    if search:
        sql += """ AND (
                announcement_id LIKE %s OR 
                title LIKE %s OR
                message LIKE %s OR 
                image_path LIKE %s OR
                admin_no LIKE %s OR
                created_at LIKE %s OR
                expire_at LIKE %s OR
                isdisplay LIKE %s OR
                isdeleted LIKE %s)
        """
        search_param = f"%{search}%"
        params += [search_param] * 9

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["announcement_id", "title", "message", "image_path", "admin_no", "created_at", "expire_at", "isdisplay", "isdeleted"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)

#===============POST/INSERT=================#

def post(announcement_info=None):
    sql = """INSERT INTO tbl_announcement
    (title, message, image_path, admin_no, created_at, expire_at, isdisplay)
    VALUES
    (%s,%s,%s,%s,%s,%s,%s)"""

    params = (
        announcement_info['title'],
        announcement_info['message'],
        announcement_info['image_path'],
        announcement_info['admin_no'],
        announcement_info['created_at'],
        announcement_info['expire_at'],
        announcement_info['isdisplay']
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============PUT/UPDATE=================#
def put(announcement_info=None):
    sql = """UPDATE tbl_announcement SET
    title = %s,
    message = %s,
    image_path = %s,
    admin_no = %s,
    created_at = %s,
    expire_at = %s,
    isdisplay = %s,
    WHERE announcement_id = %s"""

    params = (
        announcement_info['title'],
        announcement_info['message'],
        announcement_info['image_path'],
        announcement_info['admin_no'],
        announcement_info['created_at'],
        announcement_info['expire_at'],
        announcement_info['isdisplay'],
        announcement_info['announcement_id']
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============DELETE=================#
def delete(announcement_info):
    announcement_id = announcement_info.get("announcement_id")
    sql = f"UPDATE tbl_announcement SET isdeleted = 1 WHERE announcement_id = %s"
    data = execute_query(sql, (announcement_id,))
    return jsonify(data)

#===============RESTORE=================#
def delete(announcement_info):
    announcement_id = announcement_info.get("announcement_id")
    sql = f"UPDATE tbl_announcement SET isdeleted = 0 WHERE announcement_id = %s"
    data = execute_query(sql, (announcement_id,))
    return jsonify(data)