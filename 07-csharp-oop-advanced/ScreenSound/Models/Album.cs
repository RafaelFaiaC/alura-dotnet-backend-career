namespace ScreenSound.Models;

internal class Album : IRatable
{
    private List<Music> tracks = new List<Music>(); 
    private List<Rating> ratings = new List<Rating>();
    public string Name { get; }
    public int TotalDuration => tracks.Sum(music => music.Duration);
    public List<Music> Tracks => tracks;

    public double Average => ratings.Count > 0 ? ratings.Average(r => r.Value) : 0;

    public Album(string name)
    {
        Name = name;
    }

    public void AddMusic(Music music)
    {
        tracks.Add(music);
    }

    public void DisplayAlbumTracks()
    {
        Console.WriteLine($"Album: {Name}");
        Console.WriteLine("Tracks:");
        foreach (Music music in tracks)
        {
            Console.WriteLine($"- {music.Name}");
        }
        Console.WriteLine($"To listen to the entire album you will need {TotalDuration} seconds");
    }

    public void AddRating(Rating rating)
    {
        ratings.Add(rating);
    }
}
