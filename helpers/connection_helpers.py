from db.db_connections import pool

if pool is not None:
    print("[INFO] Database pool created successfully! - connection_helpers.py")
else:
    print("[ERROR] Database pool creation failed! - connection_helpers.py")
#FETCH ALL/ONE
def fetch_all(query, params=None):
    conn = pool.get_connection()
    cursor = conn.cursor(dictionary=True)

    try:
        cursor.execute(query, params or ())
        return cursor.fetchall()
    finally:
        cursor.close()
        conn.close()

def fetch_one(query, params=None):
    conn = pool.get_connection()
    cursor = conn.cursor(dictionary=True, buffered=True)

    try:
        cursor.execute(query, params or ())
        return cursor.fetchone()
    finally:
        cursor.close()
        conn.close()

# EXECUTE INSERT/UPDATE/DELETE
def execute_query(query, params=None):  
    conn = pool.get_connection()
    cursor = conn.cursor(dictionary=True)
    try:
        cursor.execute(query, params or ())
        conn.commit() 
        return {"status": "success", "POST": "Added Successfully", "PUT": "Updated Successfully", "DELETE": "Deleted Successfully"}
    except Exception as e:
        conn.rollback()
        return {"message": str(e)}
    finally:
        cursor.close()
        conn.close()