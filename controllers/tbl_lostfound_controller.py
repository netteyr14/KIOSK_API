from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one, execute_query

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None):
    allowed_tables = ["tbl_lostfound"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["lostfound_id", "item_name", "description", "image_path", "status", "reported_by", "reported_at", "claimed_by", "claimed_at"]
    if order_by and order_by not in allowed_columns:
        return jsonify({"error": "Invalid order column"}), 400

    sql = f"SELECT * FROM {table_name} WHERE 1=1"
    params = []

    # if deleted is not None:
    #     sql += " AND isdeleted = %s"
    #     params.append(deleted)

    if search:
        sql += """ AND (
                lostfound_id LIKE %s OR 
                item_name LIKE %s OR
                description LIKE %s OR 
                image_path LIKE %s OR
                status LIKE %s OR
                reported_by LIKE %s OR
                reported_at LIKE %s OR
                claimed_by LIKE %s OR
                claimed_at LIKE %s)
        """
        search_param = f"%{search}%"
        params += [search_param] * 9

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["lostfound_id", "item_name", "description", "image_path", "status", "reported_by", "reported_at", "claimed_by", "claimed_at"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)

#===============POST/INSERT=================#

def post(lostfound_info=None):
    sql = """INSERT INTO tbl_lostfound
    (item_name, description, image_path, status, reported_by, reported_at, claimed_by, claimed_at)
    VALUES
    (%s,%s,%s,%s,%s,%s,%s,%s)"""

    params = (
        lostfound_info["item_name"],
        lostfound_info["description"],
        lostfound_info["image_path"],
        lostfound_info["status"],
        lostfound_info["reported_by"],
        lostfound_info["reported_at"],
        lostfound_info["claimed_by"],
        lostfound_info["claimed_at"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============PUT/UPDATE=================#
def put(lostfound_info=None):
    sql = """UPDATE tbl_lostfound SET
    item_name = %s,
    description = %s,
    image_path = %s,
    status = %s,
    reported_by = %s,
    reported_at = %s,
    claimed_by = %s,
    claimed_at = %s
    WHERE lostfound_id = %s"""

    params = (
        lostfound_info["item_name"],
        lostfound_info["description"],
        lostfound_info["image_path"],
        lostfound_info["status"],
        lostfound_info["reported_by"],
        lostfound_info["reported_at"],
        lostfound_info["claimed_by"],
        lostfound_info["claimed_at"],
        lostfound_info["lostfound_id"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

# #===============DELETE=================#
# def delete(lostfound_info):
#     lostfound_id = lostfound_info.get("lostfound_id")
#     sql = f"UPDATE tbl_lostfound SET isdeleted = 1 WHERE lostfound_id = %s"
#     data = execute_query(sql, (lostfound_id,))
#     return jsonify(data)

# #===============DELETE=================#
# def delete(lostfound_info):
#     lostfound_id = lostfound_info.get("lostfound_id")
#     sql = f"UPDATE tbl_lostfound SET isdeleted = 0 WHERE lostfound_id = %s"
#     data = execute_query(sql, (lostfound_id,))
#     return jsonify(data)