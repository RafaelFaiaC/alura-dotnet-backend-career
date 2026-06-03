# Practicing C#: OOP with Encapsulation

> Part of the [Alura .NET Backend Career](https://www.alura.com.br/carreiras/desenvolvimento-backend-net) path.

## About

A collection of practical exercises focused on encapsulation, access modifiers, and data protection in C#. Each file contains the exercise description as a comment, followed by the solution.

---

## Exercises

| File | Description |
|------|-------------|
| `SpeedControl.cs` | Protects `currentSpeed` with a private field, exposing it only through a read-only property and an `UpdateSpeed()` method |
| `MinimumGradeValidation.cs` | Validates grade assignment through a dedicated method, using `private set` to prevent direct external modification |
| `SalaryAdjustment.cs` | Enforces a salary increase-only rule via `AdjustSalary()`, keeping the value in a private field exposed through a read-only property |
| `AccessControl.cs` | Demonstrates `public` vs `internal` class visibility using a `Patient` and `MedicalHistory` pair |
| `StudentStatus.cs` | Computes `Average` and `Status` as read-only expression-bodied properties derived from two mutable grade fields |
| `TaskControl.cs` | Protects an internal task list with a private field, exposing only `AddTask()`, `DisplayTasks()`, and a `TaskCount` read-only property |
| `WithdrawalValidation.cs` | Delegates withdrawal validation to an `internal AccountSecurity` class, separating security logic from the `BankAccount` class |
| `ContactBook.cs` | Protects a private contact list, using `LINQ Any()` to reject duplicate names and returning `bool` from `AddContact()` to signal success or failure |
| `EnrollmentControl.cs` | Enforces slot availability through an `Enroll()` method with a computed `AvailableSlots` read-only property |
| `HotelReservationSystem.cs` | Validates `DailyRate` in the property setter and `nights` in the constructor, computing `TotalValue` as a read-only expression-bodied property |

---

## Concepts Covered

- **Private fields** — storing state that must not be directly accessible or modifiable from outside the class
- **Read-only properties (`get` only)** — exposing data externally without allowing external assignment
- **`private set`** — permitting internal mutation while blocking external assignment through the property
- **Validation in methods** — centralizing business rules inside dedicated methods like `AdjustSalary()` and `AssignGrade()`
- **Validation in property setters** — enforcing constraints at the moment a value is assigned via `set`
- **Validation in constructors** — rejecting invalid state at object creation time with `throw`
- **Expression-bodied properties** — using `=>` for concise computed read-only properties like `Average`, `Status`, `TotalValue`, and `AvailableSlots`
- **`public` vs `internal` class visibility** — `public` classes are accessible from any project; `internal` classes are restricted to the same assembly
- **Delegating logic to an internal class** — isolating a specific responsibility (security validation) in a separate `internal` class to keep the main class focused
- **`readonly` fields** — preventing reassignment of a field after initialization with the `readonly` modifier
- **LINQ in encapsulated collections** — using `.Any()` to query a private list without exposing it

---

## Tech Stack

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)