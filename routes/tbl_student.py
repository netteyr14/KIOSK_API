from flask import Blueprint, request
from controllers.tbl_student_controller import get_tbl_info, get_a_row, post, put, delete, restore

tbl_student_bp = Blueprint('tbl_student_bp', __name__, url_prefix='/tbl_student') #adds this first before routes. Example: /tbl_student/get_tbl_info

#Load/Get Routes

@tbl_student_bp.route('/get_tbl_info', methods=['GET'])
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

@tbl_student_bp.route('/get_a_column', methods=['GET'])
def route_get_a_column():
    req_table_name = request.args.get('table_name')
    req_column_name = request.args.get('column_name')
    req_value = request.args.get('value')

    return get_a_row(
    table_name=req_table_name,
    column_name=req_column_name,
    value=req_value
    )

#Post/Insert, Put/Update, Delete, Restore Routes
@tbl_student_bp.route('/post', methods=['POST'])
def route_post():
    student_info = request.get_json()
    return post(student_info)

@tbl_student_bp.route('/put', methods=['PUT'])
def route_put():
    student_info = request.get_json()
    return put(student_info)

@tbl_student_bp.route('/del', methods=['DELETE'])
def route_del():
    student_info = request.get_json()
    return delete(student_info)

@tbl_student_bp.route('/res', methods=['DELETE'])
def route_res():
    student_info = request.get_json()
    return restore(student_info)