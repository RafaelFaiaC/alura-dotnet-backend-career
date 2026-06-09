using ScreenSound.Models;

namespace ScreenSound.Filters;

internal class TracksByKeyFilter
{
    public static void Execute(List<Music> tracks, int key)
    {
        var filteredTracks = tracks
        .Where(m => m.Key == key)
        .Select(m => m.Title)
        .ToList();

        Console.WriteLine($"Tracks with Key {Music.KeyValues[key]}:");
        foreach (var track in filteredTracks)
        {
            Console.WriteLine($"- {track}");
        }
    }
}
