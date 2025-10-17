from flask import Flask

def create_app():
    app = Flask(__name__)

    # Import blueprints
    from routes.Login.routes import login_bp
    from routes.Maintenance.Courses.routes import coureses_bp
    from routes.Students_Management.routes import students_management_bp
    from routes.Lost_and_Found.routes import lost_and_found_bp
    # Register blueprints with URL prefixes
    app.register_blueprint(login_bp)
    app.register_blueprint(coureses_bp)
    app.register_blueprint(students_management_bp)
    app.register_blueprint(lost_and_found_bp)
    return app

#FOR DEBUGGING PURPOSES
if __name__ == '__main__':
    app = create_app()
    app.run(debug=True, host="0.0.0.0", port=5000)