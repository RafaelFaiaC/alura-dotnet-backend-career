using ScreenSound.Menus;
using ScreenSound.Models;

Artist ledZeppelin = new Artist("Led Zeppelin");
Artist beatles = new Artist("The Beatles");
ledZeppelin.AddRating(new Rating(10));
ledZeppelin.AddRating(new Rating(8));
ledZeppelin.AddRating(new Rating(6));

Dictionary<string, Artist> registeredArtists = new Dictionary<string, Artist>();
registeredArtists.Add(ledZeppelin.Name, ledZeppelin);
registeredArtists.Add(beatles.Name, beatles);

Dictionary<int, Menu> options = new Dictionary<int, Menu>
{
    { 1, new MenuRegisterArtist() },
    { 2, new MenuRegisterAlbum() },
    { 3, new MenuDisplayArtists() },
    { 4, new MenuRateArtist() },
    { 5, new MenuRateAlbum() },
    { 6, new MenuDisplayDetails() },
    { 0, new MenuExit() }
};


void DisplayWelcomeMessage()
{
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine("Welcome to ScreenSound 2.0!\n");
}

void DisplayMenuOptions()
{
    DisplayWelcomeMessage();
    Console.WriteLine("Type 1 to register an artist");
    Console.WriteLine("Type 2 to register an album for an artist");
    Console.WriteLine("Type 3 to show all registered artists");
    Console.WriteLine("Type 4 to rate an artist");
    Console.WriteLine("Type 5 to rate an album");
    Console.WriteLine("Type 6 to show details of an artist");
    Console.WriteLine("Type 0 to exit");

    Console.Write("\nPlease select an option: ");
    int selectedOption = int.Parse(Console.ReadLine()!);

    if (options.ContainsKey(selectedOption))
    {
        options[selectedOption].Execute(registeredArtists);
        if (selectedOption != 0)
        {
            DisplayMenuOptions();
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("\nYou selected an invalid option. Please try again.");
        Console.Write("\nPress any key to go back to the menu!");
        Console.ReadKey();
        Console.Clear();
        DisplayMenuOptions();
    }
}

DisplayMenuOptions();