# C#: Applying Object-Oriented Programming

> Part of the [Alura .NET Backend Career](https://www.alura.com.br/carreiras/desenvolvimento-backend-net) path.

## Project — ScreenSound

Continuing the ScreenSound project, this course introduces object-oriented programming by modeling the domain with classes. The application evolves from a procedural structure into a model with `Music`, `Album`, and `Artist` classes relating to each other. At the end, a course challenge extends the model with `Podcast` and `Episode` classes following the same principles.

---

## Concepts Covered

- **Classes and objects** — defining custom types with attributes and behaviors, and instantiating them with `new`
- **Fields and properties** — storing state with fields and exposing it safely through C# properties with `get` and `set`
- **Read-only properties** — using `get`-only properties to prevent external modification and protect business rules
- **Expression-bodied members** — using `=>` for concise computed properties like `Description` and `Summary`
- **Constructors** — initializing object state at creation time and understanding why constructors matter for object integrity
- **Methods** — defining behaviors like `DisplayMusicDetails()`, `AddMusic()`, and `DisplayAlbumTracks()` on classes
- **Encapsulation** — hiding internal state with `private` fields and controlling access through public members
- **Object relationships** — composing classes together so `Artist` owns a list of `Album`, and `Album` owns a list of `Music`
- **Collections in classes** — using `List<T>` as a private field and exposing behavior through methods like `AddMusic()` and `AddEpisode()`
- **LINQ on collections** — using `.Sum()` for total duration and `.OrderBy()` for ordered episode listing
- **Namespaces** — organizing classes under a shared namespace and referencing them across files
- **One class per file** — structuring a multi-file project following C# conventions

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