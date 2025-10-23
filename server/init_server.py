from flask import Flask

def create_app():
    app = Flask(__name__)

    # Import blueprints
    from routes.tbl_student import tbl_student_bp
    from routes.tbl_course import tbl_course_bp
    from routes.tbl_announcement import tbl_announcement_bp
    from routes.tbl_attendance import tbl_attendance_bp
    from routes.tbl_class_sched import tbl_class_sched_bp
    from routes.tbl_faculty import tbl_faculty_bp
    # Register blueprints with URL prefixes
    app.register_blueprint(tbl_student_bp)
    app.register_blueprint(tbl_course_bp)
    app.register_blueprint(tbl_announcement_bp)
    app.register_blueprint(tbl_attendance_bp)
    app.register_blueprint(tbl_class_sched_bp)
    app.register_blueprint(tbl_faculty_bp)
    return app

#FOR DEBUGGING PURPOSES
if __name__ == '__main__':
    app = create_app()
    app.run(debug=True, host="0.0.0.0", port=5000)