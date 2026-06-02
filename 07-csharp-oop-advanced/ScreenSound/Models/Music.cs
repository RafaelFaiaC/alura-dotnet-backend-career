namespace ScreenSound.Models;

internal class Music
{
    public string Name { get; }
    public Artist Artist { get; }
    public int Duration { get; }
    public bool IsAvailable { get; set; }
    public string Description => $"The song {Name} belongs to the Artist {Artist.Name}";

    public Music(Artist artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public void DisplayMusicDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration}");
        if (IsAvailable)
        {
            Console.WriteLine("The track is available.");
        }
        else
        {
            Console.WriteLine("The track is not available.");
        }
    }
}
