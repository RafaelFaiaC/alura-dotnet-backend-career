# Practicing C#: OOP with Classes

> Part of the [Alura .NET Backend Career](https://www.alura.com.br/carreiras/desenvolvimento-backend-net) path.

## About

A collection of practical exercises focused on modeling real-world problems using classes and objects in C#. Each file contains the exercise description as a comment, followed by the solution.

---

## Exercises

| File | Description |
|------|-------------|
| `BookRegistrationInTheLibrary.cs` | Models a `Book` class with public get/set properties and displays its data |
| `TravelTicketIssuance.cs` | Models a `Ticket` class using a constructor to enforce required fields at creation |
| `RectangleAreaCalculation.cs` | Models a `Rectangle` class with a `CalculateArea()` method returning a computed value |
| `BankAccount.cs` | Models a `BankAccount` class with a read-only balance protected by `private set` and a `Deposit()` method |
| `EmployeeManagement.cs` | Models an `Employee` class with a `Promote()` method that validates the new position before updating |
| `InventoryControl.cs` | Models a `Product` class with a private field and a `Withdraw()` method that validates stock availability |
| `MovieAccessValidation.cs` | Models a `Movie` class with a `CanWatch()` method returning `bool` and object initializer syntax |
| `PurchaseOrder.cs` | Models an `Order` class with status tracking via `UpdateStatus()` and `private set` |
| `MedicalAppointmentScheduling.cs` | Models an `Appointment` class with a private state flag to distinguish first display from rescheduled display |
| `DigitalProductWithTechnicalInformation.cs` | Models two related classes — `DigitalProduct` and `TechnicalInformation` — demonstrating object composition |

---

## Concepts Covered

- **Classes and objects** — defining custom types and instantiating them with `new`
- **Public get/set properties** — exposing read and write access to class data
- **Read-only properties** — using `get`-only to prevent external modification of identity fields
- **`private set`** — allowing internal mutation while blocking external assignment
- **Private fields** — hiding implementation details completely from outside the class
- **Constructors** — enforcing required data at object creation time
- **Object initializer syntax** — assigning properties inline with `new Class { Prop = value }`
- **Methods with return values** — returning computed results like area or a `bool` access check
- **Void methods** — encapsulating behavior like displaying data or updating state
- **Input validation inside methods** — checking conditions before applying changes and displaying error messages
- **Private state flags** — using a `private bool` to track internal state changes across method calls
- **Object composition** — using one class as a property type of another to represent related data

---

## Tech Stack

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)