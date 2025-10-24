from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one, execute_query

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None, deleted=None):
    allowed_tables = ["tbl_subject"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["subject_id", "subject_code", "subject_name", "isdeleted"]
    if order_by and order_by not in allowed_columns:
        return jsonify({"error": "Invalid order column"}), 400

    sql = f"SELECT * FROM {table_name} WHERE 1=1"
    params = []

    if deleted is not None:
        sql += " AND isdeleted = %s"
        params.append(deleted)

    if search:
        sql += """ AND (
                subject_id LIKE %s OR
                subject_code LIKE %s OR
                subject_name LIKE %s OR
                isdeleted LIKE %s)
        """
        search_param = f"%{search}%"
        params += [search_param] * 4

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["subject_id", "subject_code", "subject_name", "isdeleted"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)

#===============POST/INSERT=================#

def post(subject_info=None):
    sql = """INSERT INTO tbl_subject
    (subject_code, subject_name)
    VALUES
    (%s,%s)"""

    params = (
        subject_info["subject_code"],
        subject_info["subject_name"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============PUT/UPDATE=================#
def put(subject_info=None):
    sql = """UPDATE tbl_subject SET
    subject_code = %s,
    subject_name = %s
    WHERE subject_id = %s"""

    params = (
        subject_info["subject_code"],
        subject_info["subject_name"],
        subject_info["subject_id"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============DELETE=================#
def delete(subject_info):
    subject_id = subject_info.get("subject_id")
    sql = f"UPDATE tbl_subject SET isdeleted = 1 WHERE subject_id = %s"
    data = execute_query(sql, (subject_id,))
    return jsonify(data)

#===============RESTORE=================#
def restore(subject_info):
    subject_id = subject_info.get("subject_id")
    sql = f"UPDATE tbl_subject SET isdeleted = 0 WHERE subject_id = %s"
    data = execute_query(sql, (subject_id,))
    return jsonify(data)