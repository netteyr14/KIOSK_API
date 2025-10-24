from flask import Blueprint, request
from controllers.tbl_suggestion_controller import get_tbl_info, get_a_row, post, put

tbl_suggestion_bp = Blueprint('tbl_suggestion_bp', __name__, url_prefix='/tbl_suggestion') #adds this first before routes.

#Load/Get Routes

@tbl_suggestion_bp.route('/get_tbl_info', methods=['GET'])
def route_get_tbl_info():
    req_table_name = request.args.get('table_name')
    req_order_by = request.args.get('order_by')
    req_order_type = request.args.get('order_type')
    req_search = request.args.get('search')

    return get_tbl_info(
    table_name=req_table_name,
    order_by=req_order_by,
    order_type=req_order_type,
    search=req_search
    )

@tbl_suggestion_bp.route('/get_a_column', methods=['GET'])
def route_get_a_row():
    req_table_name = request.args.get('table_name')
    req_column_name = request.args.get('column_name')
    req_value = request.args.get('value')

    return get_a_row(
    table_name=req_table_name,
    column_name=req_column_name,
    value=req_value
    )

#Post/Insert, Put/Update, Delete Routes
@tbl_suggestion_bp.route('/post', methods=['POST'])
def route_post():
    suggestion_info = request.get_json()
    return post(suggestion_info)

@tbl_suggestion_bp.route('/put', methods=['PUT'])
def route_put():
    suggestion_info = request.get_json()
    return put(suggestion_info)

# @tbl_suggestion_bp.route('/del', methods=['DELETE'])
# def route_del():
#     suggestion_info = request.get_json()
#     return delete(suggestion_info)

# @tbl_suggestion_bp.route('/res', methods=['DELETE'])
# def route_res():
#     suggestion_info = request.get_json()
#     return restore(suggestion_info)