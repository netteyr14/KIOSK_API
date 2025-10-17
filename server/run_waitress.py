from waitress import serve
from server.init_server import create_app
from routes_function.rfid_tapping import safe_loop
import argparse, threading

app = create_app()

if __name__ == '__main__':
    parser = argparse.ArgumentParser()
    parser.add_argument("--port", type=int, default=5000)
    args = parser.parse_args()

    print(f"[INFO] Starting Waitress on port {args.port}...")
    t = threading.Thread(target=safe_loop, daemon=True)
    t.start()
    serve(app, host='localhost', port=args.port, threads=20)