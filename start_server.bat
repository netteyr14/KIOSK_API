@echo on
REM Start Flask app on port 5001
start cmd /k "waitress-serve --listen=localhost:5001 server.server_flask:app"

REM Start Flask app on port 5002
start cmd /k "waitress-serve --listen=localhost:5002 server.server_flask:app"

REM Start Nginx
cd server\nginx-1.28.0
start cmd /k "nginx.exe"
