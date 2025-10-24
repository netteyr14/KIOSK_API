from flask import jsonify
from helpers.connection_helpers import fetch_all, fetch_one, execute_query

#==============GET-A-TABLE=================# #pwedeng magamit ng kahit anong routes as return
def get_tbl_info(table_name=None, order_by=None, order_type=None, search=None):
    allowed_tables = ["tbl_node"]
    if table_name not in allowed_tables:
        return jsonify({"error": "Invalid table name"}), 400
    
    allowed_columns = ["node_id", "node_name", "location", "device_uid"]
    if order_by and order_by not in allowed_columns:
        return jsonify({"error": "Invalid order column"}), 400

    sql = f"SELECT * FROM {table_name} WHERE 1=1"
    params = []

    # if deleted is not None:
    #     sql += " AND isdeleted = %s"
    #     params.append(deleted)

    if search:
        sql += """ AND (
                node_id LIKE %s OR 
                node_name LIKE %s OR
                location LIKE %s OR 
                device_uid LIKE %s)
        """
        search_param = f"%{search}%"
        params += [search_param] * 4

    if order_by:
        sql += f" ORDER BY {order_by} {order_type or 'ASC'}"

    data = fetch_all(sql, params)
    return jsonify(data)


def get_a_row(table_name=None, column_name=None, value=None):
    allowed_columns = ["node_id", "node_name", "location", "device_uid"]
    if column_name not in allowed_columns:
        return jsonify({"error": "Invalid column name"}), 400

    sql = f"SELECT * FROM {table_name} WHERE {column_name} = %s"
    row = fetch_one(sql, [value])
    return jsonify(row)

#===============POST/INSERT=================#

def post(node_info=None):
    sql = """INSERT INTO tbl_node
    (node_name, location, device_uid)
    VALUES
    (%s,%s,%s)"""

    params = (
        node_info["node_name"],
        node_info["location"],
        node_info["device_uid"]
    )

    data = execute_query(sql, params)
    return jsonify(data)

#===============PUT/UPDATE=================#
def put(node_info=None):
    sql = """UPDATE tbl_node SET
    node_name = %s,
    location = %s,
    device_uid = %s
    WHERE node_id = %s"""

    params = (
        node_info["node_name"],
        node_info["location"],
        node_info["device_uid"],
        node_info["node_id"]
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