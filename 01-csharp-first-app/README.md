# C#: Building Your First Application

> Part of the [Alura .NET Backend Career](https://www.alura.com.br/carreiras/desenvolvimento-backend-net) path.

## Project — ScreenSound

A console application for managing a music band catalog. The user can register bands, list all registered bands, submit ratings, and view the average rating for any band.

```
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
```

---

## Concepts Covered

- **Environment setup** — configuring Visual Studio and the .NET platform for C# development on Windows, Mac and Linux
- **Top-level statements** — writing executable code without explicit class or `Main` method boilerplate
- **Strongly typed language** — understanding why C# requires explicit type declaration for variables
- **Variables and primitive types** — `string`, `int` for storing different kinds of data
- **Console I/O** — reading user input and writing formatted output with `Console.ReadLine()` and `Console.WriteLine()`
- **Control flow** — `switch/case` for menu navigation and `if/else` for validation
- **Iteration** — traversing collections with both `for` and `foreach` loops
- **Methods** — declaring `void` methods to organize logic into reusable blocks, and methods with return values
- **Collections** — `List<T>` for storing ordered data, with methods like `.Add()` to insert elements
- **Dictionary** — `Dictionary<TKey, TValue>` as a key-value data structure where each key is unique and maps to a corresponding value
- **Built-in collection methods** — using `.Average()` to calculate the mean rating from a list of integers
- **String interpolation** — building dynamic messages with `$"...{variable}..."`
- **Nullable reference types** — using the `!` (null-forgiving) operator with compiler nullable warnings enabled

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
