using var fileStream = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var streamReader = new StreamReader(fileStream);

var coldplayTracks = 
    GetTracks(streamReader)
    .FilterBy(m => m.Artist.Equals("Coldplay",StringComparison.OrdinalIgnoreCase))
    .FilterBy(m => m.Duration > 400);

DisplayTracks(coldplayTracks);

void DisplayTracks (IEnumerable<Music> tracks)
{
    var counter = 1;
    Console.WriteLine("\nDisplay the tracks:");
    foreach (var track in tracks)
    {
        Console.WriteLine($"- {track.Title} ({track.Artist}) - {track.Duration} seconds");
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
        var music = new Music (title, artist, duration);
        yield return music;
        line = streamReader.ReadLine();
    }
}


static class TracksExtensios
{
    public static IEnumerable<T> FilterBy<T>(this IEnumerable<T> collection, Func<T,bool> condition)
    {
        foreach (var element in collection)
        {
            if (condition(element)) yield return element;
        }
    }
}

class Music
{
    public Music(string title, string artist, int duration)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
    }

    public string Title { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
}