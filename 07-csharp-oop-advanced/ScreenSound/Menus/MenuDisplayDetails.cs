using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuDisplayDetails : Menu
{
    internal override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        Console.Clear();
        Console.WriteLine("Artist details:\n");
        Console.Write("Type the name of the artist you want to see more details: ");
        string artistName = Console.ReadLine()!;
        if (registeredArtists.ContainsKey(artistName))
        {
            Console.WriteLine($"The artist's average rating is {registeredArtists[artistName].Average}!");
            Console.WriteLine(registeredArtists[artistName].Albums.Count > 0 ? "Albums:" :  "This Artist doesn't have registered albums");
            foreach (Album album in registeredArtists[artistName].Albums)
            {
                Console.WriteLine($"The album '{album.Name}' has an average rating of {album.Average}!");
            }
        }
        else
        {
            Console.WriteLine($"The artist '{artistName}' is not registered. Please register the artist first.");
        }
        Console.Write("\nPress any key to go back to the menu!");
        Console.ReadKey();
        Console.Clear();
    }
}
