from flask import Blueprint, request
from controllers.tbl_faculty_controller import get_tbl_info, get_a_row, post, put, delete, restore

tbl_faculty_bp = Blueprint('tbl_faculty_bp', __name__, url_prefix='/tbl_faculty') #adds this first before routes.

#Load/Get Routes

@tbl_faculty_bp.route('/get_tbl_info', methods=['GET'])
def route_get_tbl_info():
    req_table_name = request.args.get('table_name')
    req_order_by = request.args.get('order_by')
    req_order_type = request.args.get('order_type')
    req_search = request.args.get('search')
    req_deleted = request.args.get('deleted', type=int)

    return get_tbl_info(
    table_name=req_table_name,
    order_by=req_order_by,
    order_type=req_order_type,
    search=req_search,
    deleted=req_deleted
    )

@tbl_faculty_bp.route('/get_a_column', methods=['GET'])
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
@tbl_faculty_bp.route('/post', methods=['POST'])
def route_post():
    faculty_info = request.get_json()
    return post(faculty_info)

@tbl_faculty_bp.route('/put', methods=['PUT'])
def route_put():
    faculty_info = request.get_json()
    return put(faculty_info)

@tbl_faculty_bp.route('/del', methods=['PUT'])
def route_del():
    faculty_info = request.get_json()
    return delete(faculty_info)

@tbl_faculty_bp.route('/res', methods=['PUT'])
def route_res():
    faculty_info = request.get_json()
    return restore(faculty_info)