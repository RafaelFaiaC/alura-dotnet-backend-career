using System.Text.Json;
using System.Text.RegularExpressions;

using var fileStream = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var streamReader = new StreamReader(fileStream);

/*
 1. Create a collection of Artists with their respective tracks, ordered by release date. Include the total of tracks in a separate property.
 2. Generate a file in Json format with this collection.
*/

var artists = GetTracks(streamReader)
    .GroupBy(m => m.Artist)
    .Select(g => new
    {
        Artist = g.Key,
        Tracks = g.OrderBy(t => t.ReleaseDate).ToList(),
        TotalTracks = g.Count()
    })
    .OrderBy(a => a.Artist)
    .ToList();

var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "artists.json");
using var fileStreamJson = new FileStream(fileName, FileMode.Create, FileAccess.Write);
JsonSerializer.Serialize(fileStreamJson, artists, new JsonSerializerOptions { WriteIndented = true });

Console.WriteLine("Serialization completed. Check your desktop for the artists.json file.");

IEnumerable<Music> GetTracks(StreamReader streamReader)
{
    var line = streamReader.ReadLine();
    while (line is not null)
    {
        var match = Regex.Match(line, @"(\d?\d):(\d\d)");
        int duration = 0;
        if (match.Success)
        {
            var minutes = int.Parse(match.Groups[1].Value);
            var seconds = int.Parse(match.Groups[2].Value);
            duration = (minutes * 60) + seconds;
        }
        var fields = line.Split(';');
        var title = string.IsNullOrWhiteSpace(fields[0]) ? "Unknown Title" : fields[0];
        var artist = string.IsNullOrWhiteSpace(fields[1]) ? "Unknown Artist" : fields[1];
        var genre = fields[3].Split(',', StringSplitOptions.TrimEntries);
        var releaseDate = DateTime.TryParse(fields[4], out DateTime date) ? date : DateTime.MinValue;
        var music = new Music(title, artist, duration, genre, releaseDate);
        yield return music;
        line = streamReader.ReadLine();
    }
}

void DisplayTracksInTable(IEnumerable<Music> tracks)
{
    var title = "\nTracks in file:"; // literal string
    Console.WriteLine(title);

    var columnTitle = "Title".PadRight(40);
    var columnArtist = "Artist".PadRight(30);
    var columnDuration = "Duration".PadRight(10);
    var columnReleaseDate = "Release Date".PadRight(15);
    Console.WriteLine($"{columnTitle}{columnArtist}{columnDuration}{columnReleaseDate}");

    var border = string.Empty.PadRight(100, '=');
    Console.WriteLine(border);

    foreach (var track in tracks)
    {
        Console.WriteLine($"{track.Title,-40}{track.Artist,-30}{track.Duration / 60.0,-10:F2}{track.ReleaseDate,-15:dd/MM/yyyy}");
    }
}

class Music
{
    public Music(string title, string artist, int duration, IEnumerable<string> genre, DateTime releaseDate)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
        Genre = genre;
        ReleaseDate = releaseDate;
    }

    public string Title { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public IEnumerable<string> Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
}