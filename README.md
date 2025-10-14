# 🕌 MadrashaOS  

**MadrashaOS** is a modular school management system built with **.NET 8 (Clean Architecture)** and **Angular**. It manages madrasha operations including students, teachers, classes, and results.  

**Tech Stack:** Backend: ASP.NET Core 8, EF Core, SQL Server, Repository Pattern | Frontend: Angular 18, TypeScript, TailwindCSS/Bootstrap  

**Project Structure:**
src/
├── Core/
│   ├── Domain/         # Entities, enums, events, interfaces
│   └── Application/    # Business logic, services, DTOs, validators, exceptions
├── Infrastructure/     # Persistence, Identity, external services, DI
├── WebAPI/             # API controllers, middlewares, Program.cs
└── Shared/             # Shared helpers, constants, models

tests/
├── UnitTests/          # Core logic/unit tests
└── IntegrationTests/   # API/integration tests

**Getting Started:**  
1. Clone the repo: `git clone https://github.com/thisisrownak/MadrashaOS.git`  
2. Open the solution in Visual Studio  
3. Update `appsettings.json` with your SQL Server connection  
4. Run migrations: `dotnet ef database update`  
5. Run backend and frontend  

**Features:** User management (Student, Teacher, Admin), Authentication & Role-based access, Notices, Classes, and Results management  

**License:** This project is licensed under [CC BY-NC 4.0](https://creativecommons.org/licenses/by-nc/4.0/)
