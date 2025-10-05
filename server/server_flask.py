from flask import Flask, request
from routes_function.get_request import get_tbl_class_sched, get_tbl_student_management, get_course_name
from routes_function.post_request import post_student_management
from routes_function.login import login_user_function
app = Flask(__name__)

#Load/Get Routes
@app.route('/view_class_sched', methods=['GET'])
def load_tbl_class_sched():
    student_number = request.args.get("stud_number")  # key matches ?stud_number= as for inline payload instead of passing a json as argument
    return get_tbl_class_sched(student_number)

@app.route('/view_student_management', methods=['GET'])
def load_tbl_student_management():
    search = request.args.get("search")
    selection = request.args.get("selection")
    return get_tbl_student_management(search, selection)

@app.route('/tbl_course', methods=['GET'])
def load_tbl_course():
    return get_course_name()

#Insert/Post Routes
@app.route('/student_information', methods=['POST'])
def insert_student_information():
    student_info = request.get_json()
    return post_student_management(student_info)

#LOGIN
@app.route('/login_user', methods=['POST'])
def login():
    credentials = request.get_json()
    return login_user_function(credentials)
    

#Main
if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0')
