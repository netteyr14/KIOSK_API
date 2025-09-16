from waitress import serve
from server.server_flask import app
import os
if __name__ == '__main__':
    print("[INFO] Starting the server...")
    # print("@127.0.0.1:5000 or 192.168.1.7:5000 on Host")
    serve(app, host='localhost', port=5000, threads=20)
