# SignalR with .Net core and Angular

## How to setup project:

1. Clone the repository. Repository contains both .Netcore and AngularApp

2. Open .Netcore solution in one instance of VSCODE
	- Open terminal window of VSCODE and run the following commands
		a) dotnet restore (For restoring packages).
		b) dotnet build   (For building solution).
		c) dotnet run     (For run the application).
		
3. Open AngularApp and another on instance of VSCODE.
	- Open terminal window of VSCODE and run the following commands
		a) npm install (For installing packages mentioned in package.json).
		b) ng serve -o (For serving application with flage "o" to open it on default browser).
		
		
## How to check output

1. Open postman and hit the post request on "http://localhost:5000/api/message"
2. Open console window(right click and inspect / F12) of running angular application, You will see the data logged on console window.
3. Duplicate angular web window and again hit api from postman, You will see the data logged on both the instances.