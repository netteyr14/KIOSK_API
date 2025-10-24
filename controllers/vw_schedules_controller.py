from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None, deleted=None):
    allowed_tables = ["vw_schedules"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["schedule_id", "stud_number", "fname", "mname", "lname", "course_code", "course_name", "year_level", "section", "subject_code", "subject_name", "day_of_week", "time_start", "time_end", "room", "faculty_name", "isdeleted"]
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
                stud_number LIKE %s OR
                fname LIKE %s OR 
                mname LIKE %s OR
                lname LIKE %s OR
                course_code LIKE %s OR
                course_name LIKE %s OR
                year_level LIKE %s OR
                section LIKE %s OR
                subject_code LIKE %s OR
                subject_name LIKE %s OR
                day_of_week LIKE %s OR
                time_start LIKE %s OR
                time_end LIKE %s OR
                room LIKE %s OR
                faculty_name LIKE %s OR
                isdeleted LIKE %s)
        """
        search_param = f"%{search}%"
        params += [search_param] * 17

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["schedule_id", "stud_number", "fname", "mname", "lname", "course_code", "course_name", "year_level", "section", "subject_code", "subject_name", "day_of_week", "time_start", "time_end", "room", "faculty_name", "isdeleted"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)