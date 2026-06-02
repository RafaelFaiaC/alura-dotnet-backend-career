using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisterAlbum : Menu
{
    internal override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        Console.Clear();
        Console.WriteLine("Album registration\n");
        Console.Write("Type the name of the artist you want to register an album for: ");
        string artistName = Console.ReadLine()!;
        if (registeredArtists.ContainsKey(artistName))
        {
            Console.Write("Type the name of the album: ");
            string albumName = Console.ReadLine()!;
            registeredArtists[artistName].AddAlbum(new Album(albumName));
            Console.WriteLine($"The album {albumName} has been successfully registered for the artist {artistName}");
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
