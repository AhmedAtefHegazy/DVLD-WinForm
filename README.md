# DVLD-WinForm

A Windows Forms based Driving Licence Management System.

## Table of Contents
- About
- Features
- Architecture & Project Structure
- Tech Stack
- Getting Started
  - Prerequisites
  - Installation
  - Configuration
  - Running the Application
- Usage
- Project Layers Overview
- Contributing
- License
- Contact / Support

---

## About
DVLD-WinForm is a Driving Licence Management System built using Windows Forms and a layered architecture. It helps manage driving licence data by separating presentation, business logic, and data access layers.

The repository consists of:
- DVLD – the WinForms UI project
- DVLD-BusinessLayer – the business logic
- DVLD-DataAccessLayer – data access & database interaction

---

## Features
- Create, read, update, and delete driver licence records
- Validation and business rules implemented in a separate business layer
- Database abstraction in the data access layer
- Intuitive Windows Forms UI
- Modular architecture enabling extensibility

---

## Architecture & Project Structure

```txt
DVLD-WinForm/
│
├─ DVLD/                      ← WinForms UI
├─ DVLD-BusinessLayer/        ← Business logic
├─ DVLD-DataAccessLayer/      ← Data access
├─ Database/                  ← SQL setup scripts (if applicable)
├─ .gitignore
├─ LICENSE
└─ README.md
```


### Layer Responsibilities
- UI (DVLD): Handles user interaction via WinForms
- Business Layer (DVLD-BusinessLayer): Encapsulates business rules, validation, and services
- Data Access Layer (DVLD-DataAccessLayer): Manages database operations, queries, and persistence

This separation improves maintainability, testability, and scalability.

---

## Tech Stack
- Language: C#
- Framework: .NET (WinForms)
- Architecture Style: 3-tier (UI / Business / Data)
- License: MIT

---

## Getting Started

### Prerequisites
- Visual Studio (2019, 2022, or newer)
- .NET runtime / SDK that matches the project
- SQL Server (or the database used in your Data Layer)
- Git for version control

### Installation
1. Clone this repository:
   git clone https://github.com/AhmedAtefHegazy/DVLD-WinForm.git

2. Open the .sln file in Visual Studio.

3. Build the solution to restore dependencies.

### Configuration
- Go to the DVLD-DataAccessLayer project.
- Locate the connection string (App.config or Settings).
- Update it to match your SQL Server instance.
- Make sure required tables exist. If database scripts are present, run them.

### Running the Application
- Set DVLD as the startup project.
- Press F5 in Visual Studio.
- Interact with the UI to manage licences, persons, and related data.

---

## Usage
Once the application runs:
- Navigate through modules (Drivers, Licences, Tests, Applications, etc.)
- Perform CRUD operations
- Business rules are handled inside the Business Layer
- Database operations flow through the DataAccessLayer

To extend functionality:
- Add business logic → DVLD-BusinessLayer
- Add/modify forms → DVLD
- Edit database queries → DVLD-DataAccessLayer

---

## Project Layers Overview

### DVLD (UI)
- All Windows Forms (.cs) files
- Event handling and user interactions
- Calls to business logic services

### DVLD-BusinessLayer
- Validation logic
- Business rules (e.g., age limits, test requirements)
- Service classes that orchestrate operations

### DVLD-DataAccessLayer
- SQL queries and CRUD operations
- Data mapping
- Centralized database access logic

---

## Contributing
To contribute:
1. Fork the repository
2. Create a new branch: feature/YourFeature or bugfix/FixName
3. Commit changes with clear messages
4. Push the branch
5. Open a Pull Request to main or master

---

## License
This project is licensed under the MIT License.

---

## Contact / Support
For issues or questions:
- Use the GitHub Issues tab
- Contact Ahmed Atef Hegazy on GitHub: @AhmedAtefHegazy

Thank you for using DVLD-WinForm!
