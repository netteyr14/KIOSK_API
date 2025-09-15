from mysql.connector import Error, pooling

db0 = {
    'host': 'localhost',                             # ngrok/aiven host
    'user': 'root',                                  # root/mysql_acc/aiven user
    'password': 'PASS_MO',                           # database password for root/mysql_acc/aiven
    'database': 'dbipt',                             # database name for root/mysql_acc/aiven
    'port': 3306                                     # default mysql/aiven port
    #'ssl_ca': os.environ.get('AIVEN_CA_CERT')       # path to aiven ca certificate
}
pool = None

def init_db_pool_rfid():
    global pool
    try:
        pool= pooling.MySQLConnectionPool(
            pool_name = "mypool",
            pool_size = 10,
            **db0
        )
        print("[INFO] Database pool created successfully!")
    except Error as e:
        print(f"[ERROR] Database pool creation failed: {e}")


init_db_pool_rfid()

def fetch_all(query, params=None):
    conn = pool.get_connection()
    cursor = conn.cursor(dictionary=True)

    try:
        cursor.execute(query, params or ())
        return cursor.fetchall()
    finally:
        cursor.close()
        conn.close()