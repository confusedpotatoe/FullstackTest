🚀 FullstackTest
  
A robust Fullstack application featuring a .NET Web API backend and a Blazor/React frontend. This project demonstrates a deep understanding of Clean Code Architecture, Unit Testing, and Database Management
.

--------------------------------------------------------------------------------
🏗️ Project Architecture
The solution is built using Clean Architecture to ensure high testability and separation of concerns—a key requirement for Väl Godkänt (VG)
.
📁 FullstackTest (Monorepo)
├── 🌐 FullstackTest.Api            # API Layer: Controllers & DI Configuration
├── ⚙️ FullstackTest.Application    # Application Layer: Services, DTOs & Interfaces
├── 💎 FullstackTest.Domain         # Domain Layer: Entities (Product, Category)
├── 💾 FullstackTest.Infrastructure # Infrastructure Layer: EF Core, Repositories, DB
└── 🧪 FullstackTest.Tests          # Test Project: xUnit & NSubstitute

--------------------------------------------------------------------------------
✨ Key Features
Full CRUD Support: Complete Create, Read, Update, and Delete functionality
.
Relational Data: Implements a 1-to-many relationship between Categories and Products
.
Modern Backend: Built with Entity Framework Core and Async/Await for scalability
.
Repository Pattern: Uses both specific and Generic Repositories
.
Clean Dependency Injection: All services and repositories are registered via Interfaces
.

--------------------------------------------------------------------------------
🛠️ Tech Stack
Component
Technology
Frontend
Blazor / React
Backend
.NET 8 Web API
Database
SQL Server / EF Core
Testing
xUnit & NSubstitute
CI/CD
GitHub Actions (VG Requirement)

--------------------------------------------------------------------------------
🚦 Getting Started
Clone the repo:
Database Setup: Update the DefaultConnection string in appsettings.json and run:
Run the App: Hit F5 in Visual Studio or use dotnet run on both the API and Frontend projects.

--------------------------------------------------------------------------------
🧪 Testing & Quality
This project includes 7+ unit tests covering "Happy Path" scenarios and "Edge Cases"
.
Framework: xUnit
Mocking: NSubstitute (used to mock repository interfaces for service testing)
Pattern: All tests follow the Arrange-Act-Assert (AAA) principle
.

--------------------------------------------------------------------------------
📋 Grading Checklist
✅ Godkänt (G) Requirements
[x] Public repo with README and 5+ commits
.
[x] Full CRUD on Frontend with error handling
.
[x] Backend with 2+ entities and 1-many relation
.
[x] DI + Interfaces used in Controllers
.
[x] 7+ Unit tests using NSubstitute and AAA
.
🌟 Väl Godkänt (VG) Requirements
[x] Clean Code Architecture (4+ distinct projects)
.
[ ] GitHub Actions build and test automation
.
[ ] Frontend Deployment online (e.g., GitHub Pages)
.

--------------------------------------------------------------------------------
Developed by Milo Eriksson (confusedpotatoe)
