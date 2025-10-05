from flask import jsonify
from db.db_connections import init_db_pool

#DB_CONNECTION
pool = init_db_pool()
#LOGIN FUNCTION
def login_user_function(credentials):
    uname = credentials.get('username')
    pword = credentials.get('password')
    conn = pool.get_connection()
    cursor = conn.cursor(dictionary=True)
    try:
        sql = "SELECT * FROM tbl_admin WHERE uname = %s AND pword = %s"
        cursor.execute(sql, (uname, pword))
        user = cursor.fetchone()       
        if user:
            fullname = user["fullname"]
            role = user["role"]
            return jsonify({"status": "success", "message": "Login successful", "fullname": fullname,  "role": role})
        else:
            return jsonify({"status": "failure", "message": "Invalid username or password"}), 401
    except Exception as e:
        return jsonify({"status": "failure", "message": f"An error occurred during login: {str(e)}"}), 500
    finally:
        cursor.close()
        conn.close()