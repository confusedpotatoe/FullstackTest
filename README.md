# 🚀 FullstackTest - Product & Category Manager

This is a Fullstack application built with a **.NET Web API** and a **Blazor/React** frontend, following **Clean Architecture** principles.

---

## 📂 Project Structure
This solution uses a multi-project setup to ensure separation of concerns:
*   **API:** Controllers and DI configuration [2].
*   **Application:** Business logic, DTOs, and Interfaces [3].
*   **Domain:** Core entities (Products & Categories) [3].
*   **Infrastructure:** Database context and Repository implementations [3].
*   **Tests:** xUnit project with NSubstitute [2, 4].

---

## ✨ Features
- **Full CRUD:** Create, Read, Update, and Delete products and categories [1, 3].
- **Relationships:** 1-to-many relationship between Categories and Products [3].
- **Async/Await:** Fully asynchronous backend for better performance [3].
- **Unit Testing:** Includes **7+ tests** following the AAA pattern [4].

---

## 🛠️ Setup Instructions
1. Clone the repository.
2. Update your connection string in `appsettings.json`.
3. Run `Update-Database` in the Package Manager Console.
4. Start the project!

---
*Developed by Milo Eriksson*
