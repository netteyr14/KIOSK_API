@echo on
REM Start Waitress app on port 5001
start cmd /k "python -m server.run_waitress --port=5001"

REM Start Waitress app on port 5002
start cmd /k "python -m server.run_waitress --port=5002"

REM REM Start RFID standby service (COM3 handler)
start cmd /k "python -m server.rfid_stand_by"

REM Start Nginx
cd server\nginx-1.28.0
start cmd /k "nginx.exe"
