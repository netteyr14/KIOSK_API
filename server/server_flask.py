from flask import Flask, request
from routes_function.get_request import get_tbl_class_sched, get_tbl_student_management, get_course_cbo, get_course_dgv, get_a_column
from routes_function.post_request import post_student_management
from routes_function.put_request import put_student_management
from routes_function.del_request import del_student_management
from routes_function.login import login_user_function
app = Flask(__name__)

#Load/Get Routes
@app.route('/load_tbl_class_sched', methods=['GET'])
def load_tbl_class_sched():
    student_number = request.args.get("stud_number")  # key matches ?stud_number= as for inline payload instead of passing a json as argument
    return get_tbl_class_sched(student_number)

@app.route('/load_tbl_student_management', methods=['GET'])
def load_tbl_student_management():
    search = request.args.get("search")
    selection = request.args.get("selection")
    return get_tbl_student_management(search, selection)

@app.route('/load_tbl_course_cbo', methods=['GET'])
def load_tbl_course_cbo():
    return get_course_cbo()

@app.route('/load_tbl_course_dgv', methods=['GET'])
def load_tbl_course_dgv():
    return get_course_dgv()

@app.route('/load_a_column', methods=['GET'])
def load_a_column():
    stud_num = request.args.get("stud_num")
    sql = request.args.get("sql")
    return get_a_column(stud_num, sql)

#Insert/Post Routes
@app.route('/insert_student_information', methods=['POST'])
def insert_student_information():
    student_info = request.get_json()
    return post_student_management(student_info)

#Update/Put Routes
@app.route('/update_student_information', methods=['PUT'])
def update_student_information():
    student_info = request.get_json()
    return put_student_management(student_info)

#Delete/Delete Routes
@app.route('/delete_student_information', methods=['POST'])
def delete_student_information():
    student_info = request.get_json()
    return del_student_management(student_info)

#LOGIN
@app.route('/login_user', methods=['POST'])
def login_user():
    credentials = request.get_json()
    return login_user_function(credentials)
    

#Main
if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0')
