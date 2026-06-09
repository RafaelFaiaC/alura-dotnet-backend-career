using ScreenSound.Models;

namespace ScreenSound.Filters;

internal class SortedArtistFilter
{
    public static void Execute(List<Music> tracks)
    {
        var sortedArtists = tracks.Select(m => m.Artist).Distinct().OrderBy(a => a).ToList();
        Console.WriteLine("Sorted Artists:");
        foreach (var artist in sortedArtists)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
