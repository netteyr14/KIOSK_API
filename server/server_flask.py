from flask import Flask, jsonify, request
from get_functions.load_tables import get_tbl_class_sched, get_tbl_student_management
from get_functions.load_cbo import get_course_name, get_section, get_year
app = Flask(__name__)

#Routes
@app.route('/view_class_sched', methods=['GET'])
def load_tbl_class_sched():
    student_number = request.args.get("student_number")  # key matches C# dictionary
    data = get_tbl_class_sched(student_number)
    return jsonify(data)

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
#Main
if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0')
