from mysql.connector import Error, pooling

db0 = {
    'host': 'localhost',                             # ngrok/aiven host
    'user': 'root',                                  # root/mysql_acc/aiven user
<<<<<<< HEAD
    'password': 'PASS_MO',                           # database password for root/mysql_acc/aiven
=======
    'password': 'Ambin123456123456',                 # database password for root/mysql_acc/aiven
>>>>>>> 8ee50a7bd7765501fd8642fd098eb246461f3a33
    'database': 'dbcstakiosk',                       # database name for root/mysql_acc/aiven
    'port': 3306                                     # default mysql/aiven port
    #'ssl_ca': os.environ.get('AIVEN_CA_CERT')       # path to aiven ca certificate
}

def init_db_pool_rfid():
    global pool
    try:
        pool = pooling.MySQLConnectionPool(
            pool_name = "mypool",
            pool_size = 10,
            **db0
        )
        print("[INFO] Database pool created successfully!")
        return pool     
    except Error as e:
        print(f"[ERROR] Database pool creation failed: {e}")


