using ScreenSound.Models;

namespace ScreenSound.Filters;

internal class TracksByArtistFilter
{
    public static void Execute(List<Music> tracks, string artist)
    {
        var filteredTracks = tracks
            .Where(m => m.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
            .Select(m => m.Title)
            .OrderBy(t => t)
            .ToList();
        Console.WriteLine($"Tracks by artist: {artist}");
        foreach (var track in filteredTracks)
        {
            Console.WriteLine($"- {track}");
        }
    }
}
