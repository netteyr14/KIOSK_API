from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None, deleted=None):
    allowed_tables = ["vw_students"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["student_id", "stud_number", "rfid_card", "fname", "mname", "lname", "course_code", "course_name", "year_level", "section", "isactive", "isdeleted", "created_at", "img_path"]
    if order_by and order_by not in allowed_columns:
        return jsonify({"error": "Invalid order column"}), 400

    sql = f"SELECT * FROM {table_name} WHERE 1=1"
    params = []

    if deleted is not None:
        sql += " AND isdeleted = %s"
        params.append(deleted)

    if search:
        sql += """ AND (
                student_id LIKE %s OR
                stud_number LIKE %s OR
                rfid_card LIKE %s OR
                fname LIKE %s OR
                mname LIKE %s OR
                lname LIKE %s OR
                course_code LIKE %s OR
                course_name LIKE %s OR
                year_level LIKE %s OR
                section LIKE %s OR
                isactive LIKE %s OR
                isdeleted LIKE %s OR
                created_at LIKE %s OR
                img_path LIKE %s)
        """
        search_param = f"%{search}%"
        params += [search_param] * 14

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["student_id", "stud_number", "rfid_card", "fname", "mname", "lname", "course_code", "course_name", "year_level", "section", "isactive", "isdeleted", "created_at", "img_path"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)