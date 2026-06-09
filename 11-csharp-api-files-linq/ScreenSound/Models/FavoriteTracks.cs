using System.Text.Json;

namespace ScreenSound.Models;

internal class FavoriteTracks
{
    public string Name { get; set; }
    public List<Music> Tracks { get; set; }

    public FavoriteTracks(string name)
    {
        Name = name;
        Tracks = new List<Music>();
    }

    public void AddTrack(Music track)
    {
        Tracks.Add(track);
    }

    public void DisplayFavoriteTracks()
    {
        Console.WriteLine($"Favorite Tracks: {Name}");
        foreach (var track in Tracks)
        {
            Console.WriteLine($"- {track.Title} by {track.Artist}");
        }
    }

    public void ExportToJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            tracks = Tracks
        }, new JsonSerializerOptions { WriteIndented = true });

        string fileName = $"{Name}_favorite_tracks.json";

        File.WriteAllText(fileName, json);

        Console.WriteLine($"JSON file was successfully created at: {Path.GetFullPath(fileName)}");
    }
}
