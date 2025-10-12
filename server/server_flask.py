from flask import Flask

def create_app():
    app = Flask(__name__)

    # Import blueprints
    from routes.Login.routes import login_bp
    from routes.Maintenance.Courses.routes import coureses_bp
    from routes.Students_Management.routes import students_management_bp

    # Register blueprints with URL prefixes
    app.register_blueprint(login_bp)
    app.register_blueprint(coureses_bp)
    app.register_blueprint(students_management_bp)

    return app