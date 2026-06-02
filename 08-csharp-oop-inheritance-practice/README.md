# Practicing C#: OOP with Inheritance

> Part of the [Alura .NET Backend Career](https://www.alura.com.br/carreiras/desenvolvimento-backend-net) path.

## About

A collection of practical exercises focused on inheritance, interfaces, abstract classes, and composition in C#. Each file contains the exercise description as a comment, followed by the solution.

---

## Exercises

| File | Description |
|------|-------------|
| `DigitalItemsCataloging.cs` | Models a `Scroll` class inheriting from `DigitalItem`, passing the title to the base constructor with `base()` |
| `PassengerData.cs` | Models a `Passenger` class inheriting from `Person`, extending it with a `TicketQuantity` attribute |
| `VIPClientSystem.cs` | Models a `VIPClient` class inheriting from `Person`, adding loyalty level and VIP code attributes |
| `EmployeeRegistration.cs` | Models `FullTimeEmployee` and `Freelancer` classes inheriting from a shared `Employee` base class |
| `ProfessionCertificate.cs` | Models an `abstract` base class `Profession` that cannot be instantiated directly, with `Analyst` and `Teacher` as concrete subclasses |
| `DevicesWithSensors.cs` | Defines an `ISensor` interface with `Activate()` and `Deactivate()`, implemented by `TemperatureSensor` and `PresenceSensor` |
| `PaymentSystem.cs` | Combines inheritance and interfaces — `CreditPayment` and `BoletoPayment` inherit from `Person` and implement `IPayment` |
| `ComputerAssembly.cs` | Models a `Computer` class composed of `Processor` and `Motherboard` objects, demonstrating composition over inheritance |
| `ServiceManagement.cs` | Combines interfaces and composition — `Maintenance` and `Consulting` implement `IService` and hold an `Employee` through composition |
| `CoursePlatform.cs` | Combines interfaces and composition — `ProgrammingCourse` and `DesignCourse` implement `ICourse` and hold an `Instructor` through composition |

---

## Concepts Covered

- **Inheritance** — extending a base class to reuse attributes and behavior across related types
- **Base constructor chaining** — passing arguments to the parent constructor with `: base()`
- **Abstract classes** — defining a class that cannot be instantiated directly, serving only as a blueprint for subclasses
- **`protected` constructor** — restricting direct instantiation while still allowing subclass access
- **Interfaces** — defining contracts that unrelated types can fulfill, guaranteeing consistent behavior across different hierarchies
- **Inheritance + interfaces combined** — a class can inherit from a base class and implement one or more interfaces simultaneously
- **Composition over inheritance** — modeling "has-a" relationships by holding objects as properties instead of extending them
- **Interfaces + composition combined** — implementing a contract while delegating part of the behavior to a composed object
- **`ISensor`, `IPayment`, `IService`, `ICourse`** — interface naming convention with the `I` prefix as a C# standard

---

## Tech Stack

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)