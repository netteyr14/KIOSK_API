from flask import Flask, jsonify, request
from get_tables.load_tables import tbl_class_sched, tbl_student_management
app = Flask(__name__)

#Routes
@app.route('/view_class_sched', methods=['GET'])
def load_tbl_class_sched():
    student_number = request.args.get("student_number")  # key matches C# dictionary
    data = tbl_class_sched(student_number)
    return jsonify(data)

@app.route('/view_student_management', methods=['GET'])
def load_tbl_student_management():
    return tbl_student_management()

#Main
if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0')
