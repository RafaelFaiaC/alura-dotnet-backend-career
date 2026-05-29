namespace ScreenSound;

internal class Artist
{
    private List<Album> albums = new List<Album>();
    public string Name { get; }

    public Artist(string name)
    {
        Name = name;
    }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void DisplayArtistAlbums()
    {
        Console.WriteLine($"Band: {Name}");
        Console.WriteLine("Albums:");
        foreach (Album album in albums)
        {
            Console.WriteLine($"- {album.Name} (Duration: {album.TotalDuration})");
        }
    }
}
