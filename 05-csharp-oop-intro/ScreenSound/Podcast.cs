namespace ScreenSound;

internal class Podcast
{
    List<Episode> episodes = new List<Episode>();
    public string Name { get; }
    public string Host { get; }
    public int TotalEpisodes => episodes.Count;

    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void DisplayPodcastDetails()
    {
        Console.WriteLine($"Podcast: {Name}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total of Episodes: {TotalEpisodes}");
        Console.WriteLine("Episodes:");
        foreach (Episode episode in episodes.OrderBy(e => e.Number))
        {
            Console.WriteLine(episode.Summary);
        }
    }
}
