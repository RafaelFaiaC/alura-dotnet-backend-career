using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisterArtist : Menu
{
    internal override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        Console.Clear();
        Console.WriteLine("Artist registration\n");
        Console.Write("Type the name of the artist you want to register: ");
        string artistName = Console.ReadLine()!;
        registeredArtists.Add(artistName, new Artist(artistName));
        Console.WriteLine($"The artist {artistName} has been successfully registered!");
        Console.Write("\nPress any key to go back to the menu!");
        Console.ReadKey();
        Console.Clear();
    }
}
