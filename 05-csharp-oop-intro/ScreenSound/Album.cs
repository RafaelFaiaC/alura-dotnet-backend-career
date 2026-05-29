namespace ScreenSound;

internal class Album
{
    private List<Music> musics = new List<Music>();
    public string Name { get; }
    public int TotalDuration => musics.Sum(music => music.Duration);

    public Album(string name)
    {
        Name = name;
    }

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void DisplayAlbumTracks()
    {
        Console.WriteLine($"Album: {Name}");
        Console.WriteLine("Tracks:");
        foreach (Music music in musics)
        {
            Console.WriteLine($"- {music.Name}");
        }
        Console.WriteLine($"To listen to entire album you will need {TotalDuration} seconds");
    }
}
