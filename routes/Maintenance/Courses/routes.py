from flask import Blueprint, request
from routes_function.get_request import get_course_dgv
from routes_function.post_request import post_course_information
from routes_function.put_request import put_course_information
from routes_function.del_request import del_course_information

coureses_bp = Blueprint('coureses_bp', __name__)

#Loads DGV for Course Maintenance
@coureses_bp.route('/load_tbl_course_dgv', methods=['GET'])
def load_tbl_course_dgv():
    return get_course_dgv()

#Insert/Post Routes
@coureses_bp.route('/insert_course_information', methods=['POST'])
def insert_course_information():
    course_info = request.get_json()
    return post_course_information(course_info)

#Update/Put Routes
@coureses_bp.route('/update_course_information', methods=['PUT'])
def update_course_information():
    course_info = request.get_json()
    return put_course_information(course_info)

#Delete/Delete Routes
@coureses_bp.route('/delete_course_information', methods=['POST'])
def delete_course_information():
    course_info = request.get_json()
    return del_course_information(course_info)