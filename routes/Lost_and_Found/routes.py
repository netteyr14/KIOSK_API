from flask import Blueprint, request
from routes_function.get_request import get_tbl_lost_and_found, get_a_column_for_lostfound
from routes_function.post_request import post_lostfound_info
from routes_function.put_request import put_lostfound_info
from routes_function.del_request import del_lostfound_info
# from routes_function.post_request import
# from routes_function.put_request import
# from routes_function.del_request import

lost_and_found_bp = Blueprint('lost_and_found_bp', __name__)

#Loads DGV for Lost and Found with search and filter
@lost_and_found_bp.route('/load_tbl_lostfound', methods=['GET'])
def load_tbl_lostfound():
    item_name = request.args.get("search")
    status = request.args.get("selection")
    return get_tbl_lost_and_found(item_name, status)

#Loads Images on Lost and Found
@lost_and_found_bp.route('/load_an_image_lostfound', methods=['GET'])
def load_an_image_lostfound():
    lostfound_id = request.args.get("lostfound_id")
    sql = request.args.get("sql")
    return get_a_column_for_lostfound(lostfound_id, sql)

#Insert/Post Routes
@lost_and_found_bp.route('/insert_lostfound_info', methods=['POST'])
def insert_lostfound_info():
    lostfound_info = request.get_json()
    return post_lostfound_info(lostfound_info)

#Update/Put Routes
@lost_and_found_bp.route('/update_lostfound_info', methods=['PUT'])
def update_lostfound_info():
    lostfound_info = request.get_json()
    return put_lostfound_info(lostfound_info)

#Delete/Delete Routes
@lost_and_found_bp.route('/delete_lostfound_info', methods=['POST'])
def delete_lostfound_info():
    lostfound_info = request.get_json()
    return del_lostfound_info(lostfound_info)