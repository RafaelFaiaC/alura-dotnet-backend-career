using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExit : Menu
{
    internal override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        Console.WriteLine("\nExiting the application! Bye bye!");

    }
}
