using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRateAlbum : Menu
{
    internal override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        Console.Clear();
        Console.WriteLine("Album rating:\n");
        Console.Write("Type the name of the artist you want to rate: ");
        string artistName = Console.ReadLine()!;
        if (registeredArtists.ContainsKey(artistName))
        {
            Console.Write("Type the name of the album you want to rate: ");
            string albumName = Console.ReadLine()!;
            if (registeredArtists[artistName].Albums.Any(albums => albums.Name.Equals(albumName)))
            {
                Album album = registeredArtists[artistName].Albums.First(albums => albums.Name.Equals(albumName));
                Console.Write("Type the rating you want to give to the album (1 to 5): "); // TO DO: validate the rating input
                int albumRating = int.Parse(Console.ReadLine()!);
                album.AddRating(new Rating(albumRating));
                Console.WriteLine("The album has been successfully rated!");
            }
            else
            {
                Console.WriteLine("The album you are trying to rate is not registered. Please register the album before rating it.");
            }
        }
        else
        {
            Console.WriteLine("The artist you are trying to rate is not registered. Please register the artist before rating it.");
        }
        Console.Write("\nPress any key to go back to the menu!");
        Console.ReadKey();
        Console.Clear();
    }
}
