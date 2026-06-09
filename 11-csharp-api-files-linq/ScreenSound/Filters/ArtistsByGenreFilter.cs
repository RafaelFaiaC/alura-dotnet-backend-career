using ScreenSound.Models;

namespace ScreenSound.Filters;

internal class ArtistsByGenreFilter
{
    public static void Execute(List<Music> tracks, string genre)
    {
        var artistsByGenre = tracks.Where(m => m.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase))
                                  .Select(m => m.Artist)
                                  .Distinct()
                                  .OrderBy(a => a)
                                  .ToList();
        Console.WriteLine($"Artists in the genre: {genre}");
        foreach (var artist in artistsByGenre)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
