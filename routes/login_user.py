from flask import Blueprint, request
from controllers.login_controller import login_user_function

login_bp = Blueprint('login_bp', __name__, url_prefix='/login') #adds this first before routes

#LOGIN
@login_bp.route('/user_credential', methods=['POST'])
def login_user():
    credentials = request.get_json()
    return login_user_function(credentials)