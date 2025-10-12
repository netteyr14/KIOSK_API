from flask import Blueprint, request
from routes_function.login import login_user_function

login_bp = Blueprint('login_bp', __name__)

#LOGIN
@login_bp.route('/login_user', methods=['POST'])
def login_user():
    credentials = request.get_json()
    return login_user_function(credentials)