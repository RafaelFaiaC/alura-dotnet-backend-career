# Practicing C#: OOP with Polymorphism

> Part of the [Alura .NET Backend Career](https://www.alura.com.br/carreiras/desenvolvimento-backend-net) path.

## About

A collection of practical exercises focused on polymorphism, method overriding, abstract classes, interfaces, and method overloading in C#. Each file contains the exercise description as a comment, followed by the solution.

---

## Exercises

| File | Description |
|------|-------------|
| `Calculator.cs` | Implements method overloading — three versions of `Sum()` accepting different parameter types and counts |
| `EmployeeReport.cs` | Overrides `GenerateReport()` in `Manager` and `Developer` subclasses; objects are referenced through the base `Employee` type |
| `ContentEvaluation.cs` | Overrides `DisplayInfo()` in `RecordedLesson` and `ComplementaryMaterial`; calls `base.DisplayInfo()` to reuse the parent implementation |
| `DisplayingMedia.cs` | Overrides `DisplayDetails()` in `Image` and `Video`; iterates a `List<Media>` calling the correct subclass version at runtime |
| `ExperienceReservations.cs` | Overrides `Confirm()` in `InPersonReservation` and `OnlineReservation`; processes a mixed list through the base `Reservation` type |
| `UrbanTransportSimulator.cs` | Overrides `CalculateTime()` in `Bus`, `Subway`, and `Bicycle`; uses `GetType().Name` to display the class name dynamically |
| `ScheduledTaskExecution.cs` | Defines an `abstract` class `ScheduledTask` with an `abstract Execute()` method; `BackupTask`, `ReportTask`, and `CleanupTask` provide the concrete implementations |
| `SystemNotifications.cs` | Defines `INotification` with `SendMessage()`; `EmailNotification`, `SmsNotification`, and `PushNotification` implement the interface with channel-specific logic |
| `InterestCalculationForDifferentLoanProfiles.cs` | Defines `ILoan` with `CalculateFinalValue()`; `StudentLoan`, `BusinessOwnerLoan`, and `RetireeLoan` apply their own interest rates |
| `ButtonActionsInGraphicalUserInterface.cs` | Defines `IButtonAction` with `Execute()`; `SaveAction`, `EditAction`, and `DeleteAction` implement it and are dispatched from a `List<IButtonAction>` |

---

## Concepts Covered

- **Method overloading** — multiple methods with the same name but different signatures, resolved at compile time
- **`virtual` and `override`** — marking base class methods as overridable and replacing them in subclasses
- **`abstract` class and `abstract` method** — enforcing that every subclass provides its own implementation, with no default in the base
- **Interfaces as polymorphic contracts** — grouping unrelated types under a shared interface and treating them uniformly at runtime
- **Base type references** — declaring variables as `List<BaseType>` or `BaseType ref = new SubType()` to dispatch the correct method at runtime
- **`base.Method()`** — invoking the parent's implementation from within an overriding method to extend rather than replace behavior
- **`GetType().Name`** — retrieving the runtime class name as a string without hardcoding it
- **Polymorphic `foreach`** — iterating a collection of base type references and calling overridden methods, each resolving to the correct subclass at runtime

---

## Tech Stack

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)