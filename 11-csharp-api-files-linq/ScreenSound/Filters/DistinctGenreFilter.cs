using ScreenSound.Models;

namespace ScreenSound.Filters;

internal class DistinctGenreFilter
{
    public static void Execute(List<Music> tracks)
    {
        var allGenres = tracks.Select(m => m.Genre).Distinct().ToList();
        Console.WriteLine("All Genres:"); 
        foreach(var genre in allGenres)
        {
            Console.WriteLine($"- {genre}");
        }
    }
}
