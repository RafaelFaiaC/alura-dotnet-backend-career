namespace ScreenSound.Models;

internal class Artist : IRatable
{
    private List<Album> albums = new List<Album>();
    private List<Rating> ratings = new List<Rating>();
    public string Name { get; }
    public double Average => ratings.Count > 0 ? ratings.Average(r => r.Value) : 0;
    public List<Album> Albums => albums;

    public Artist(string name)
    {
        Name = name;
    }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddRating(Rating rating)
    {
        ratings.Add(rating);
    }

    public void DisplayArtistAlbums()
    {
        Console.WriteLine($"Artist: {Name}");
        Console.WriteLine("Albums:");
        foreach (Album album in albums)
        {
            Console.WriteLine($"- {album.Name} (Duration: {album.TotalDuration})");
        }
    }
}
