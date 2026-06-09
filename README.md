FullstackTest - Product and Category Management
This project is a full-stack application developed as part of the C# II course. It handles the management of products and categories through a RESTful API and a modern frontend
.
Project Structure (Clean Architecture)
The project is organized following Clean Code Architecture to ensure a clear separation of concerns and to improve testability
:
FullstackTest.Api: Contains the controllers and the API configuration
.
FullstackTest.Application: Contains business logic services, DTOs (Data Transfer Objects), and interfaces
.
FullstackTest.Domain: Contains the core domain entities, such as Product and Category
.
FullstackTest.Infrastructure: Contains the database context (EF Core) and the repository implementations
.
FullstackTest.Tests: A separate xUnit project dedicated to backend unit testing
.
Features
Full CRUD Functionality: Supports creating, reading, updating, and deleting data for at least two entities
.
Entity Relationships: Implements a 1-to-many relationship (Categories having many Products)
.
Asynchronous Programming: Uses async/await throughout the entire application stack
.
Repository Pattern: Utilizes both a Generic Repository and specific repository implementations
.
Dependency Injection: All services and repositories are registered via interfaces in the DI container
.
Technical Stack
Back-end: .NET Web API built with Entity Framework Core
.
Database: SQL Server or SQL Express
.
Front-end: [Insert your choice: Blazor / React] featuring full CRUD capabilities and basic error handling
.
Unit Testing: xUnit using NSubstitute for mocking repository interfaces
.
Installation and Setup
Clone the monorepo: git clone https://github.com/confusedpotatoe/FullstackTest.git
.
Configure your SQL Server Connection String in the appsettings.json file within the API project
.
Update the database using the Package Manager Console: Update-Database.
Launch both the API and the Front-end projects.
Unit Testing
The solution includes at least 7 unit tests that verify the logic within the service layer by mocking repository interfaces
. Each test is clearly named and follows the Arrange-Act-Assert (AAA) principle with descriptive comments
.
To execute the tests, use the following command: dotnet test
Väl Godkänt (VG) Requirements
To achieve the higher grade, this project implements:
Advanced Project Structure: A strict Clean Code Architecture with multiple distinct projects
.
GitHub Actions: A CI/CD pipeline that automatically builds the project and runs all tests on every commit
.
Online Deployment: The front-end application is deployed and accessible online
.

--------------------------------------------------------------------------------
Reminders for your submission:
Commit Count: You currently have 2 commits recorded in your history
. Ensure you have at least 5 commits with clear, descriptive messages before the final deadline to meet the G requirements
.
Front-end Selection: Once you decide between Blazor or React, make sure to update the "Technical Stack" section in this README to reflect your choice
.
GitHub Actions: If you are aiming for VG, remember to add your .yml workflow file so that your tests run automatically on GitHub
.
