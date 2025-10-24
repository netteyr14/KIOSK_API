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
    from routes.tbl_admin import tbl_admin_bp
    from routes.tbl_lostfound import tbl_lostfound_bp
    from routes.tbl_node import tbl_node_bp
    from routes.tbl_schedule import tbl_schedule_bp
    from routes.tbl_subject import tbl_subject_bp
    from routes.tbl_suggestion import tbl_suggestion_bp
    from routes.vw_announcements import vw_announcements_bp
    from routes.vw_attendances import vw_attendances_bp
    from routes.vw_students import vw_students_bp
    from routes.vw_schedules import vw_schedules_bp
    # Register blueprints with URL prefixes
    app.register_blueprint(tbl_student_bp)
    app.register_blueprint(tbl_course_bp)
    app.register_blueprint(tbl_announcement_bp)
    app.register_blueprint(tbl_attendance_bp)
    app.register_blueprint(tbl_class_sched_bp)
    app.register_blueprint(tbl_faculty_bp)
    app.register_blueprint(tbl_admin_bp)
    app.register_blueprint(tbl_lostfound_bp)
    app.register_blueprint(tbl_node_bp)
    app.register_blueprint(tbl_schedule_bp)
    app.register_blueprint(tbl_subject_bp)
    app.register_blueprint(tbl_suggestion_bp)
    app.register_blueprint(vw_announcements_bp)
    app.register_blueprint(vw_attendances_bp)
    app.register_blueprint(vw_students_bp)
    app.register_blueprint(vw_schedules_bp)
    return app

#FOR DEBUGGING PURPOSES
if __name__ == '__main__':
    app = create_app()
    app.run(debug=True, host="0.0.0.0", port=5000)