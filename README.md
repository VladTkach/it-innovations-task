# it-innovations-task

## build:
- **Backend**:
  - Open **backend/Library.sln** with Visual Studio and build a solution.

- **Frontend**:
  - Open folder **frontend/** with Visual Studio Code or with console and execute command `npm i`.

### DB creation:
- Db will be created after the first launch of **Library.WebApi** project or you can execute comand `dotnet ef database update` in folder **backend/Library.WebApi/**.
  - **Note:** Default connection string for SQL Server will be **(localhost)**.

### launch
- **Backend**:
  - Open **backend/Library.sln** with Visual Studio, build a solution, and start a project **Library.WebApi**.
    - **Note:** Application will be started on port 5000.

- **Frontend**:
  - Open folder **frontend/** in Visual Studio Code and execute command `ng serve` in a console. The application will be started on port 4200.
