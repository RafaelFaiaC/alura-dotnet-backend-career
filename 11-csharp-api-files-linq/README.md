# C#: Consuming APIs, Writing Files and Using LINQ

> Part of the [Alura .NET Backend Career](https://www.alura.com.br/carreiras/desenvolvimento-backend-net) path.

## Project — ScreenSound 3.0

Continuing the ScreenSound project, this course connects the application to a real external API, introduces LINQ for data querying and manipulation, and adds the ability to export a favorite tracks playlist to a JSON file that can be consumed by a frontend.

---

## Features Developed

| Feature | Class / Method |
|---------|---------------|
| Fetch tracks from external API | `HttpClient.GetStringAsync()` in `Program.cs` |
| Display a single track's details | `Music.DisplayMusicInfo()` |
| List all distinct genres | `DistinctGenreFilter.Execute()` |
| List all artists sorted alphabetically | `SortedArtistFilter.Execute()` |
| Filter artists by genre | `ArtistsByGenreFilter.Execute()` |
| Filter tracks by artist | `TracksByArtistFilter.Execute()` |
| Filter tracks by musical key | `TracksByKeyFilter.Execute()` |
| Build and display a favorites playlist | `FavoriteTracks.AddTrack()` + `DisplayFavoriteTracks()` |
| Export favorites playlist to JSON file | `FavoriteTracks.ExportToJson()` |

---

## Concepts Covered

- **`HttpClient`** — making HTTP GET requests to an external API and reading the response as a string
- **`try/catch`** — handling exceptions that may occur during HTTP requests to provide a more resilient application
- **`using` statement with `HttpClient`** — ensuring proper resource disposal after the request completes
- **JSON deserialization** — converting a JSON response into a typed `List<Music>` with `JsonSerializer.Deserialize<T>()`
- **`[JsonPropertyName]`** — mapping JSON field names to C# property names when they differ
- **`async/await`** — using `await` with `GetStringAsync()` for non-blocking HTTP calls
- **LINQ — filtering** — using `.Where()` to select elements that match a condition
- **LINQ — projection** — using `.Select()` to extract a specific field from each element
- **LINQ — deduplication** — using `.Distinct()` to remove duplicate values from a sequence
- **LINQ — ordering** — using `.OrderBy()` to sort results alphabetically
- **LINQ — first match** — using `.First()` with a predicate to find a specific track in the list
- **`StringComparison.OrdinalIgnoreCase`** — case-insensitive string comparison in LINQ queries
- **Static arrays** — using a `static readonly string[]` in `Music` to map integer key values to musical note names
- **File writing** — using `File.WriteAllText()` to export serialized data to a `.json` file
- **JSON serialization** — converting an object to a formatted JSON string with `JsonSerializer.Serialize()` and `WriteIndented = true`
- **`Path.GetFullPath()`** — resolving and displaying the absolute path of the exported file
- **Folder organization** — separating responsibilities into `Models/` and `Filters/` namespaces

---

## How to Run

**Requirements:** [.NET 10 SDK](https://dotnet.microsoft.com/download) — internet connection required to fetch the API data.

```bash
cd ScreenSound
dotnet run
```

---

## Tech Stack

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)