from routes_function.rfid_tapping import safe_loop
import threading
import time

if __name__ == '__main__':
    print("[INFO] Starting RFID standby service (COM3 handler)...")
    t = threading.Thread(target=safe_loop, daemon=True)
    t.start()

    # Keep main thread alive forever
    try:
        while True:
            time.sleep(1)
    except KeyboardInterrupt:
        print("\n[INFO] RFID standby service stopped manually.")
