from flask import Blueprint, request
from routes_function.get_request import get_course_dgv

coureses_bp = Blueprint('coureses_bp', __name__)

@coureses_bp.route('/load_tbl_course_dgv', methods=['GET'])
def load_tbl_course_dgv():
    return get_course_dgv()