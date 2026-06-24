# Tolu Banking App

A console-based multi-account banking system built in C#, developed as a
portfolio project to demonstrate practical application of:

- Object-Oriented Programming (encapsulation, abstraction, inheritance, polymorphism)
- SOLID principles
- Dependency Injection
- Unit Testing & TDD (NUnit)
- Design Patterns (Factory, Strategy, Observer, and others)

## Status

🚧 Work in progress — built incrementally as part of a structured C# bootcamp.
See [DESIGN_NOTES.md](./DESIGN_NOTES.md) for the reasoning behind key decisions
made at each stage.

## Features

- [ ] Create and manage multiple customers and accounts
- [ ] Support for multiple account types (Savings, Current, ISA)
- [X] Deposits, withdrawals, and transfers with validation
- [ ] Interest calculation per account type
- [ ] Transaction history and receipts
- [ ] Notification on large transactions
- [ ] Full unit test coverage of core banking logic

## Architecture

_Diagram and overview to be added as the account hierarchy and service layer
take shape._

## Tech Stack

- C# / .NET 8
- NUnit (unit testing)
- Console UI

## Getting Started

```bash
git clone https://github.com/<your-username>/tolu-banking-app.git
cd tolu-banking-app
dotnet build
dotnet run --project ToluBankingApp
```

## Running Tests

```bash
dotnet test
```

## Project Structure

```
ToluBankingApp/
├── ToluBankingApp/          # Main application
└── ToluBankingApp.Tests/    # NUnit test project
```

## Design Notes

Key architectural decisions and the reasoning behind them are documented in
[DESIGN_NOTES.md](./DESIGN_NOTES.md), organised by build phase.

## Author

Built by Tee as part of a career transition into software development.
