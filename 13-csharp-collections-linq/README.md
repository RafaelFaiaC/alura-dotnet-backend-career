# C#: Collections, LINQ, Strings and Regular Expressions

> Part of the [Alura .NET Backend Career](https://www.alura.com.br/carreiras/desenvolvimento-backend-net) path.

## About

A sequence of seven small console projects, each isolated in its own folder and `.csproj`, progressively building up C#'s data-manipulation toolkit: from arrays and lists, through building a custom iterable collection from scratch, to filtering with hand-rolled delegates, official LINQ operators, string handling, regular expressions, and JSON serialization. Most projects (from `03` onward) share the same theme — reading a music track catalog from a `musicas.csv` file — with the CSV format evolving slightly across folders to match what each one needs to parse.

---

## Projects

| # | Project | Description |
|---|---------|-------------|
| 01 | `01-IntroToCollections` | Compares indexed `List<T>` access with a custom `DayOfWeekCollection`, and contrasts a `yield`-based iterator against a hand-written `IEnumerator<T>` |
| 02 | `02-CollectionOperations` | A `Playlist` (`ICollection<Music>` + `HashSet<Music>` for deduplication) and a `MusicPlayer` (`Queue<Music>` + `Stack<Music>`) for playback queue/history |
| 03 | `03-AbstractingTheDataSource` | Reads tracks from a CSV file with a lazy `yield`-based reader, filtered through a custom `FilterBy` extension method built on `Func<T, bool>` |
| 04 | `04-LINQ` | Replaces `FilterBy` with official LINQ operators — filtering, projection, ordering, grouping, aggregation, quantifiers and element access |
| 05 | `05-Strings` | String immutability, interning, comparison and formatting, applied while rendering the catalog as an aligned table |
| 06 | `06-RegularExpressions` | Five `Regex`-based pattern searches over track titles and artists, combined with LINQ filters |
| 07 | `07-Serialization` | Groups tracks by artist with LINQ, then serializes the result to a formatted `artists.json` file |

---

## Concepts Covered

- **Arrays vs. Lists** — `List<T>` resizes dynamically via `Add()`, unlike a fixed-size array
- **Generics** — `List<T>`, `IEnumerable<T>` and `IEnumerator<T>` enforce type safety at compile time
- **`yield return`** — writing iterator methods without manually implementing `IEnumerator<T>`
- **Lazy evaluation** — elements are only computed as they are actually consumed by the caller
- **Custom `IEnumerable<T>` / `IEnumerator<T>`** — implementing an iterable class both with `yield return` and with a manual state machine (`MoveNext`, `Reset`, `Current`)
- **Explicit interface implementation** — the non-generic `IEnumerable.GetEnumerator()` delegating to the generic version
- **`ICollection<T>`** — implementing `Add`, `Remove`, `Contains`, `Clear`, `CopyTo`, `Count` and `IsReadOnly` for a custom `Playlist`
- **`HashSet<T>` for deduplication** — used alongside a `List<T>` to reject duplicate tracks while preserving insertion order
- **Overriding `Equals` and `GetHashCode`** — defining value-based equality so `HashSet<T>` and `Dictionary<TKey, TValue>` behave correctly
- **`IComparable` and `IComparer<T>`** — a natural sort order via `CompareTo()`, plus separate comparer classes for alternative sort criteria
- **`Dictionary<TKey, TValue>`** — counting item occurrences with `TryGetValue`
- **`Queue<T>` and `Stack<T>`** — modeling FIFO and LIFO behavior for a playback queue and history
- **`FileStream` and `StreamReader` with `using`** — reading a file line by line with automatic resource disposal
- **Extension methods and delegates** — a generic `FilterBy<T>` built on `Func<T, bool>` as a hand-built precursor to LINQ's `.Where()`
- **Encapsulating logic in methods** — isolating parsing, filtering and display into dedicated methods
- **Type conversion** — `int.Parse` and `Convert.ToInt32` to convert CSV fields
- **Lambda expressions** — used throughout as arguments to LINQ operators and delegates
- **LINQ filtering and projection** — `.Where()`, `.Select()`, `.Distinct()`
- **LINQ ordering and grouping** — `.OrderBy()`, `.ThenBy()`, `.GroupBy()`
- **LINQ flattening** — `.SelectMany()` to project a nested `Genre` collection into a single flat sequence
- **LINQ aggregation** — `.Count()`, `.Sum()`, `.Min()`, `.Max()`, `.Average()`
- **LINQ quantifiers and existence checks** — `.Any()`, `.Contains()`
- **LINQ element access** — `.First()`, `.FirstOrDefault()`, `.MaxBy()`
- **Chaining LINQ operators into pipelines** — combining multiple operators in a single query expression
- **String immutability** — `Replace()` and similar methods return a new string instead of mutating the original
- **String pool and interning** — comparing `ReferenceEquals` results for literals, `new string(...)`, and `string.Intern()`
- **String comparison and manipulation** — `Replace`, `ToUpper`, `StartsWith`, `EndsWith`, `Contains` with `StringComparison.OrdinalIgnoreCase`
- **String formatting** — `PadLeft`/`PadRight` and composite format specifiers in interpolated strings (e.g. `{value,-10:F2}`)
- **Validation and safe conversion** — `int.TryParse`, `DateTime.TryParse` and `string.IsNullOrWhiteSpace` with fallback defaults
- **`Regex` class and capture groups** — reusing a compiled `Regex` instance and reading `match.Groups[n].Value`
- **Regex quantifiers and backreferences** — optional (`?`) elements, repeated-character (`(\w)\1`) and start/end (`^(\w+).*\1$`) patterns
- **Combining regex with LINQ filters** — feeding `regex.IsMatch()` into `.Where()` pipelines
- **`GroupBy` with anonymous-object projection** — combining a grouping key with aggregated data in a single `.Select(g => new { ... })`
- **JSON serialization** — `JsonSerializer.Serialize()` with `JsonSerializerOptions { WriteIndented = true }`
- **`Environment.SpecialFolder` and `Path.Combine`** — resolving a cross-machine file path instead of hardcoding one

---

## How to Run

**Requirements:** [.NET 10 SDK](https://dotnet.microsoft.com/download)

Each folder is an independent console project; all seven are grouped under `DataManipulation.slnx` for convenience.

```bash
cd 04-LINQ
dotnet run
```

> Several projects define local functions that aren't called by default (e.g. `ArtistWithMostTracks` in `04-LINQ`, every function in `06-RegularExpressions`). Uncomment or add a call to the one you want to inspect before running.

---

## Tech Stack

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
