from flask import Flask, jsonify, request
from get_tables.load_tables import tbl_class_sched, tbl_student_management
app = Flask(__name__)

#Routes
@app.route('/tbl_class_sched', methods=['GET'])
def load_tbl_class_sched():
    return tbl_class_sched()

#Main
if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0')
