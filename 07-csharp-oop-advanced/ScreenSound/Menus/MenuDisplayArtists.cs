using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuDisplayArtists : Menu
{
    internal override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        Console.Clear();
        Console.WriteLine("Showing all registered artists:\n");
        foreach (string artist in registeredArtists.Keys)
        {
            Console.WriteLine($"- {artist}");
        }
        Console.Write("\nPress any key to go back to the menu!");
        Console.ReadKey();
        Console.Clear();
    }
}
