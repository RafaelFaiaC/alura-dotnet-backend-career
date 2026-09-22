using var fileStream = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var streamReader = new StreamReader(fileStream);

QuantifierOperations(streamReader);

void QuantifierOperations(StreamReader streamReader)
{
    var tracks = GetTracks(streamReader).ToList();

    var artists = tracks
        .OrderBy(t => t.Artist)
        .GroupBy(t => t.Artist)
        .Where(g => g.Any(m => m.Duration >= 480));

    Console.WriteLine($"Artists with tracks that has at least 480 seconds:");
    foreach (var artist in artists)
    {
        Console.WriteLine($"- {artist.Key}");
    }

    var reggae = tracks
        .OrderBy(t => t.Artist)
        .GroupBy(t => t.Artist)
        .Where(g => g.Any(m => m.Genre.Contains("Reggae")));

    Console.WriteLine($"\nArtists with reggae genre tracks: ");
    foreach (var artist in reggae)
    {
        Console.WriteLine($"- {artist.Key}");
    }
}

void ArtistWithMostTracks(StreamReader streamReader)
{
    var artists =
        GetTracks(streamReader)
        .GroupBy(m => m.Artist)
        .Select(g => new { Artist = g.Key, Tracks = g, Total = g.Count() })
        .MaxBy(a => a.Total);
    Console.WriteLine($"The artist with most tracks is {artists.Artist} with {artists.Total} tracks!");
}

void ElementOperations(StreamReader streamReader)
{
    var tracks =
        GetTracks(streamReader).ToList();

    var firstTrack = tracks.First();
    Console.WriteLine($"The first track is {firstTrack.Title}");

    var longestTrack = tracks.MaxBy(m => m.Duration);
    Console.WriteLine($"The longest track is {longestTrack!.Title} with {longestTrack!.Duration} seconds.");
}

void GroupingOperations(StreamReader streamReader)
{
    var artists =
        GetTracks(streamReader)
        .OrderBy(m => m.Artist)
        .GroupBy(m => m.Artist);

    foreach (var artist in artists.Take(5))
    {
        Console.WriteLine($"\nArtist: {artist.Key} with {artist.Count()} tracks");
        foreach (var music in artist)
        {
            Console.WriteLine($"- {music.Title}");
        }
    }
}

void TracksStatistics(StreamReader streamReader)
{
    var statistics = GetTracks(streamReader).ToList();
    Console.WriteLine($"\nThere are {statistics.Count()} songs in the collection.");
    Console.WriteLine($"\nThere are {statistics.Count(m => m.Duration > 600)} songs longer than 10 minutes in the collection.");
    Console.WriteLine($"\nThe shortest song in the collection takes {statistics.Min(m => m.Duration)} seconds.");
    Console.WriteLine($"\nThe longest song in the collection takes {statistics.Max(m => m.Duration)} seconds.");
    Console.WriteLine($"\nThe average song duration in the collection is {statistics.Average(m => m.Duration):F2} seconds.");
    Console.WriteLine($"\nIt will take you {statistics.Sum(m => m.Duration) / (24 * 3600)} days to listen to the entire collection!");
}

void ProjectOperations2(StreamReader streamReader)
{
    var genres =
    GetTracks(streamReader)
        .SelectMany(m => m.Genre)
        .Distinct()
        .OrderBy(g => g);

    foreach (var genre in genres)
    {
        Console.WriteLine(genre);
    }
}

void ProjectOperations(StreamReader streamReader)
{
    var artists =
        GetTracks(streamReader)
            .Select(m => m.Artist)
            .Distinct()
            .OrderBy(a => a);


    foreach (var artist in artists)
    {
        Console.WriteLine(artist);
    }
}

void OrderAndFilterOperations(StreamReader streamReader)
{
    var coldplayTracks =
    GetTracks(streamReader)
        .Where(m => m.Artist.Equals("Coldplay", StringComparison.OrdinalIgnoreCase))
        .Where(m => m.Genre.Any(g => g.Equals("Rock", StringComparison.OrdinalIgnoreCase)))
        .Where(m => m.Duration > 300)
        .OrderBy(m => m.Artist)
        .ThenBy(m => m.Duration);

    DisplayTracks(coldplayTracks);
}

void DisplayTracks(IEnumerable<Music> tracks)
{
    var counter = 1;
    Console.WriteLine("\nDisplay the tracks:");
    foreach (var track in tracks)
    {
        Console.WriteLine($"- {track.Title} ({track.Artist}) - {track.Duration} seconds | Genre: {track.Genre}");
        counter++;
        if (counter > 10) break;
    }
}

IEnumerable<Music> GetTracks(StreamReader streamReader)
{
    var line = streamReader.ReadLine();
    while (line != null)
    {
        var fields = line.Split(";");
        var title = fields[0];
        var artist = fields[1];
        var duration = int.Parse(fields[2]);
        var genre = fields[3].Split(", ");
        var music = new Music(title, artist, duration, genre);
        yield return music;
        line = streamReader.ReadLine();
    }
}

class Music
{
    public Music(string title, string artist, int duration, IEnumerable<string> genre)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
        Genre = genre;
    }

    public string Title { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public IEnumerable<string> Genre { get; set; }
}