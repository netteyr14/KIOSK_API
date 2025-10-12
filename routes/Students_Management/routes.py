from flask import Blueprint, request
from routes_function.get_request import get_tbl_class_sched, get_tbl_student_management, get_course_cbo, get_a_column
from routes_function.post_request import post_student_management
from routes_function.put_request import put_student_management
from routes_function.del_request import del_student_management

students_management_bp = Blueprint('students_management', __name__)

#Load/Get Routes
@students_management_bp.route('/load_tbl_class_sched', methods=['GET'])
def load_tbl_class_sched():
    student_number = request.args.get("stud_number")  # key matches ?stud_number= as for inline payload instead of passing a json as argument
    return get_tbl_class_sched(student_number)

@students_management_bp.route('/load_tbl_student_management', methods=['GET'])
def load_tbl_student_management():
    search = request.args.get("search")
    selection = request.args.get("selection")
    return get_tbl_student_management(search, selection)

@students_management_bp.route('/load_tbl_course_cbo', methods=['GET'])
def load_tbl_course_cbo():
    return get_course_cbo()

@students_management_bp.route('/load_an_image', methods=['GET'])
def load_a_column():
    stud_num = request.args.get("stud_num")
    sql = request.args.get("sql")
    return get_a_column(stud_num, sql)

#Insert/Post Routes
@students_management_bp.route('/insert_student_information', methods=['POST'])
def insert_student_information():
    student_info = request.get_json()
    return post_student_management(student_info)

#Update/Put Routes
@students_management_bp.route('/update_student_information', methods=['PUT'])
def update_student_information():
    student_info = request.get_json()
    return put_student_management(student_info)

#Delete/Delete Routes
@students_management_bp.route('/delete_student_information', methods=['POST'])
def delete_student_information():
    student_info = request.get_json()
    return del_student_management(student_info)