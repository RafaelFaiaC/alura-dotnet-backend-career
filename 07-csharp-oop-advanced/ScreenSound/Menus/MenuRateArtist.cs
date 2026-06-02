using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRateArtist : Menu
{
    internal override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        Console.Clear();
        Console.WriteLine("Artist rating:\n");
        Console.Write("Type the name of the artist you want to rate: ");
        string artistName = Console.ReadLine()!;
        if (registeredArtists.ContainsKey(artistName))
        {
            Console.Write("Type the rating you want to give to the artist (1 to 5): "); // TO DO: validate the rating input
            int artistRating = int.Parse(Console.ReadLine()!);
            registeredArtists[artistName].AddRating(new Rating(artistRating));
            Console.WriteLine("The artist has been successfully rated!");
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
