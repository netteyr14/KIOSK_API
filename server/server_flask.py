from flask import Flask, request
from routes_function.get_request import get_tbl_class_sched, get_tbl_student_management, get_course_name, get_section, get_year
from routes_function.post_request import post_student_management

app = Flask(__name__)

#Load/Get Routes
@app.route('/view_class_sched', methods=['GET'])
def load_tbl_class_sched():
    student_number = request.args.get("stud_number")  # key matches C# dictionary
    return get_tbl_class_sched(student_number)

@app.route('/view_student_management', methods=['GET'])
def load_tbl_student_management():
    return get_tbl_student_management()

@app.route('/tbl_course', methods=['GET'])
def load_tbl_course():
    return get_course_name()

@app.route('/tbl_section', methods=['GET'])
def load_tbl_section():
    return get_section()

@app.route('/tbl_year', methods=['GET'])
def load_tbl_year():
    return get_year()

#Post Routes
@app.route('/student_information', methods=['POST'])
def insert_student_information():
    student_info = request.get_json()
    return post_student_management(student_info)

#Main
if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0')
