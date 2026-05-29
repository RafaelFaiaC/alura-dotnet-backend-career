namespace ScreenSound;

internal class Music
{
    public Artist Artist { get; }
    public string Name { get; }
    public int Duration { get; }
    public bool IsAvailable { get; set; }
    public string Description => $"The song {Name} belongs to the Artist {Artist}";

    public Music(Artist artist, string name, int duration, bool isAvailable)
    {
        Artist = artist;
        Name = name;
        Duration = duration;
        IsAvailable = isAvailable;
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
