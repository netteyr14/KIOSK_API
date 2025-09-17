from waitress import serve
from server.server_flask import app
import argparse

if __name__ == '__main__':
    parser = argparse.ArgumentParser()
    parser.add_argument("--port", type=int, default=5000)
    args = parser.parse_args()

    print(f"[INFO] Starting Waitress on port {args.port}...")
    serve(app, host='localhost', port=args.port, threads=20)