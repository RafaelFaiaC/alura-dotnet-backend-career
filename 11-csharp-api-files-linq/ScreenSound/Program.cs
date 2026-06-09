using ScreenSound.Models;
using ScreenSound.Filters;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var tracks = JsonSerializer.Deserialize<List<Music>>(response)!;
        //tracks[1].DisplayMusicInfo();
        //DistinctGenreFilter.Execute(tracks);
        //SortedArtistFilter.Execute(tracks);
        //ArtistsByGenreFilter.Execute(tracks, "pop");
        //TracksByArtistFilter.Execute(tracks, "Justin Bieber");
        TracksByKeyFilter.Execute(tracks, 1);
        FavoriteTracks myFavoriteTracks = new FavoriteTracks("Rafael");
        myFavoriteTracks.AddTrack(tracks.First(t => t.Title.Equals("Baby") && t.Artist.Equals("Justin Bieber")));
        myFavoriteTracks.AddTrack(tracks.First(t => t.Title.Equals("Beauty And A Beat") && t.Artist.Equals("Justin Bieber")));
        myFavoriteTracks.AddTrack(tracks.First(t => t.Title.Equals("Boyfriend") && t.Artist.Equals("Justin Bieber")));
        myFavoriteTracks.AddTrack(tracks.First(t => t.Title.Equals("One Time") && t.Artist.Equals("Justin Bieber")));
        myFavoriteTracks.AddTrack(tracks.First(t => t.Title.Equals("What Do You Mean?") && t.Artist.Equals("Justin Bieber")));

        //myFavoriteTracks.DisplayFavoriteTracks();

        //myFavoriteTracks.ExportToJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"We had a problem: {ex.Message}");
    }
}