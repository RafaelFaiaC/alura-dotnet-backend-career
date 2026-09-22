using System.Text.RegularExpressions;

using var fileStream = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var streamReader = new StreamReader(fileStream);

/*
- Find artists with especial characters in their name
- Find titles with two words
- Find titles that starts and ends with the same word
- Find titles with repeated letters
- Find titles with roman numerals
*/

void FindArtistsWithSpecialCharacters(StreamReader streamReader)
{
    Regex regex = new Regex(@"[^a-zA-Z0-9\s]"); // Good pratice to create a regex object and reuse it instead of creating a new one every time you need to use it.

    var artists = GetTracks(streamReader)
        .Where(a => regex.IsMatch(a.Artist))
        .Select(a => a.Artist)
        .Distinct()
        .OrderBy(a => a);

    foreach (var artist in artists)
    {
        Console.WriteLine(artist);
    }
}

void FindTitlesWithTwoWords(StreamReader streamReader)
{
    Regex regex = new Regex(@"^\w+ \w+$");
    var tracks = GetTracks(streamReader)
        .Where(m => regex.IsMatch(m.Title))
        .Select(m => m.Title)
        .Distinct()
        .OrderBy(m => m);

    foreach (var track in tracks)
    {
        Console.WriteLine(track);
    }
}

void FindTitlesThatStartsAndEndsWithTheSameWord(StreamReader streamReader)
{
    Regex regex = new Regex(@"^(\w+).*\1$");
    var tracks = GetTracks(streamReader)
        .Where(m => regex.IsMatch(m.Title))
        .Select(m => m.Title)
        .Distinct()
        .OrderBy(m => m);

    foreach (var track in tracks)
    {
        Console.WriteLine(track);
    }
}

void FindTitlesWithRepeatedLetters(StreamReader streamReader)
{
    Regex regex = new Regex(@"(\w)\1");
    var tracks = GetTracks(streamReader)
        .Where(m => regex.IsMatch(m.Title))
        .Select(m => m.Title)
        .Distinct()
        .OrderBy(m => m);
    foreach (var track in tracks)
    {
        Console.WriteLine(track);
    }
}

void FindTitlesWithRomanNumerals(StreamReader streamReader)
{
    Regex regex = new Regex(@"\b[IVXLCDM]+\b");
    var tracks = GetTracks(streamReader)
        .Where(m => regex.IsMatch(m.Title))
        .Select(m => m.Title)
        .Distinct()
        .OrderBy(m => m);
    foreach (var track in tracks)
    {
        Console.WriteLine(track);
    }
}

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