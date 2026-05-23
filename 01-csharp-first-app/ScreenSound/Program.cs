Dictionary<string, List<int>> registeredBands = new Dictionary<string, List<int>>();
registeredBands.Add("The Beatles", new List<int> { 5, 5, 4, 5 });
registeredBands.Add("Led Zeppelin", new List<int>());

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
    Console.WriteLine("Welcome to ScreenSound!\n");
}

void DisplayMenuOptions()
{
    DisplayWelcomeMessage();
    Console.WriteLine("Type 1 to register a band");
    Console.WriteLine("Type 2 to show all registered bands");
    Console.WriteLine("Type 3 to rate a band");
    Console.WriteLine("Type 4 to show the average rating of a band");
    Console.WriteLine("Type 0 to exit");

    Console.Write("\nPlease select an option: ");
    int selectedOption = int.Parse(Console.ReadLine()!);

    switch (selectedOption)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            ShowRegisteredBands();
            break;
        case 3:
            RateBand();
            break;
        case 4:
            ShowAverageRating();
            break;
        case 0:
            Console.WriteLine("\nExiting the application! Bye bye!");
            break;
        default:
            Console.WriteLine("\nYou selected an invalid option. Please try again.");
            break;
    }

}

void RegisterBand()
{
    Console.Clear();
    Console.WriteLine("Band registration\n");
    Console.Write("Type the name of the band you want to register: ");
    string bandName = Console.ReadLine()!;
    registeredBands.Add(bandName, new List<int>());
    Console.WriteLine($"The band {bandName} has been successfully registered!");
    Console.Write("\nPress any key to go back to the menu!");
    Console.ReadKey();
    Console.Clear();
    DisplayMenuOptions();
}

void ShowRegisteredBands()
{
    Console.Clear();
    Console.WriteLine("Showing all registered bands:\n");
    foreach(string band in registeredBands.Keys)
    {
        Console.WriteLine($"- {band}");
    }
    Console.Write("\nPress any key to go back to the menu!");
    Console.ReadKey();
    Console.Clear();
    DisplayMenuOptions();
}

void RateBand()
{
    Console.Clear();
    Console.WriteLine("Band rating:\n");
    Console.Write("Type the name of the band you want to rate: ");
    string bandName = Console.ReadLine()!;
    if (registeredBands.ContainsKey(bandName))
    {
        Console.Write("Type the rating you want to give to the band (1 to 5): ");
        int bandRate = int.Parse(Console.ReadLine()!);
        registeredBands[bandName].Add(bandRate);
        Console.WriteLine("The band has been successfully rated!");
    }
    else
    {
        Console.WriteLine("The band you are trying to rate is not registered. Please register the band before rating it.");
    }
    Console.Write("\nPress any key to go back to the menu!");
    Console.ReadKey();
    Console.Clear();
    DisplayMenuOptions();
}

void ShowAverageRating()
{
    Console.Clear();
    Console.WriteLine("Band rating average:\n");
    Console.Write("Type the name of the band you want to see the average rate: ");
    string bandName = Console.ReadLine()!;
    if (registeredBands.ContainsKey(bandName))
    {
        if (registeredBands[bandName].Count > 0)
        {
            Console.WriteLine($"The band average rating is {registeredBands[bandName].Average()}!");
        }
        else
        {
            Console.WriteLine($"The band {bandName} does not have any ratings yet.");
        }
    }
    else
    {
        Console.WriteLine("The band you are trying to see the average is not registered. Please register the band before trying to see its average.");
    }
    Console.Write("\nPress any key to go back to the menu!");
    Console.ReadKey();
    Console.Clear();
    DisplayMenuOptions();
}

DisplayMenuOptions();