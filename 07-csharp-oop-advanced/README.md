# C#: Mastering Object-Oriented Programming

> Part of the [Alura .NET Backend Career](https://www.alura.com.br/carreiras/desenvolvimento-backend-net) path.

## Project — ScreenSound 2.0

Continuing the ScreenSound project, this course evolves the application architecture with namespaces, folders, inheritance, interfaces, and static members. The menu system is refactored from a single procedural block into a hierarchy of classes, each responsible for one operation.

---

## Concepts Covered

- **Namespaces and folders** — organizing classes into `Models` and `Menus` folders with matching namespaces for logical grouping and maintainability
- **Wrapping primitives** — encapsulating primitive types like `int` into dedicated classes such as `Rating` to enable validation and additional behavior
- **Access modifiers on classes** — `internal` classes are visible only within the same project; `public` classes are accessible from any referencing project
- **Static members** — methods that don't access instance data can be marked `static` and called via the type name; familiar examples include `Console.WriteLine()`, `int.Parse()`, and `Console.Clear()`
- **The hidden `Main()` method** — `Program.cs` is a class with a static `Main()` entry point that .NET conceals behind top-level statements to reduce the learning curve for beginners
- **Inheritance** — sharing common behavior across related classes using a base class, avoiding duplication and improving maintainability
- **`virtual` and `override`** — marking base class members as `virtual` to allow subclasses to replace the behavior with `override`; using `base` to still invoke the ancestor's implementation when needed
- **Interfaces** — defining contracts that types from different hierarchies can implement; interfaces have no concrete code and cannot be instantiated with `new`
- **`IRatable` interface** — both `Artist` and `Album` implement `IRatable`, guaranteeing they expose `Average` and `AddRating()` regardless of their position in the hierarchy
- **Single Responsibility** — classes and methods with too many lines signal too many responsibilities, making the codebase harder to maintain and read; each menu operation is isolated in its own class

---

## How to Run

**Requirements:** [.NET 10 SDK](https://dotnet.microsoft.com/download)

```bash
cd ScreenSound
dotnet run
```

---

## Tech Stack

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)