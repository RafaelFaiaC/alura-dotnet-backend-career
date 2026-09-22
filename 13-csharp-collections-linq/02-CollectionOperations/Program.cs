
using System.Collections;
using System.ComponentModel.DataAnnotations;

Music music1 = new Music { Title = "Ghost", Artist = "Justin Bieber", Duration = 200 };
Music music2 = new Music { Title = "All that matters", Artist = "Justin Bieber", Duration = 180 };
Music music3 = new Music { Title = "Confident", Artist = "Justin Bieber", Duration = 210 };
Music music4 = new Music { Title = "God is a weapon", Artist = "Falling in Reverse", Duration = 240 };
Music music5 = new Music { Title = "feelings are fatal", Artist = "mxmtoon", Duration = 150 };

Playlist myPlaylist = new Playlist { Name = "My Favorite Songs" };
myPlaylist.Add(music1);
myPlaylist.Add(music2);
myPlaylist.Add(music3);
myPlaylist.Add(music4);
myPlaylist.Add(music5);
myPlaylist.Add(new Music { Title = "Confident", Artist = "Justin Bieber", Duration = 210 });

DisplayPlaylist(myPlaylist);

Playlist justinBieber = new Playlist { Name = "Justin Bieber Songs"};
justinBieber.Add(music1);
justinBieber.Add(music2);
justinBieber.Add(music3);

DisplayPlaylist(justinBieber);

MusicPlayer player = new MusicPlayer();
player.AddMusicToQueue(music4);
player.AddMusicToQueue(justinBieber);

DisplayQueue(player);
DisplayHistory(player);

//DisplayMostPlayedTracks(myPlaylist, justinBieber);

//myPlaylist.OrderByDuration();
//DisplayPlaylist(myPlaylist);

//myPlaylist.OrderByArtist();
//DisplayPlaylist(myPlaylist);

//myPlaylist.OrderByTitle();
//DisplayPlaylist(myPlaylist);

void DisplayHistory(MusicPlayer player)
{
    Console.WriteLine("\nDisplaying the History:");
    foreach (Music music in player.History())
    {
        Console.WriteLine($"- {music.Title}");
    }
}


void DisplayQueue(MusicPlayer player)
{
    Console.WriteLine("\nDisplaying the queue:");
    foreach (Music music in player.Queue())
    {
        Console.WriteLine($"- {music.Title}");
    }
}

void DisplayMostPlayedTracks(Playlist playlist1, Playlist playlist2)
{
    Dictionary<Music, int> mostPlayed = new Dictionary<Music, int>();
    foreach (Music music in playlist1)
    {
        mostPlayed.Add(music, 1);
    }
    foreach (Music music in playlist2)
    {
        if (mostPlayed.TryGetValue(music, out int value))
        {
            mostPlayed[music] = ++value;
        }
        else
        {
            mostPlayed.Add(music, 1);
        }
    }
    List<KeyValuePair<Music, int>> topTracks = new List<KeyValuePair<Music, int>>(mostPlayed); //[..ranking]
    topTracks.Sort(new ByCount());

    Console.WriteLine("\n The most included tracks in Playlists:");
    int counter = 1;
    foreach (var pair in topTracks)
    {
        Console.WriteLine($"- {pair.Key.Title}");
        counter++;
        if (counter > 3) break;
    }
}

void RemoveMusicByTitle(Playlist playlist, string title)
{
    var foundMusic = playlist.GetMusicByTitle(title);
    if (foundMusic != null)
    {
        Console.WriteLine("\nDeleting music...");
        playlist.Remove(foundMusic);
    }
    else
    {
        Console.WriteLine("\nMusic not found!");
    }
}

void DisplayRandomMusic(Playlist playlist)
{
    var randomMusic = playlist.GetRandomMusic();
    if (randomMusic != null)
    {
        Console.WriteLine($"\nThe random music is {randomMusic.Title}");
    }
    else
    {
        Console.WriteLine("\n The playlist is empty!");
    }
}

void DisplayPlaylist(Playlist playlist)
{
    Console.WriteLine($"\nPlaying the playlist \"{playlist.Name}\"");
    foreach (Music music in playlist)
    {
        Console.WriteLine($"- {music.Title} ({music.Artist}) - {music.Duration} seconds");
    }
}

class ByCount : IComparer<KeyValuePair<Music, int>>
{
    public int Compare(KeyValuePair<Music, int> x, KeyValuePair<Music, int> y)
    {
        return y.Value.CompareTo(x.Value);
    }
}

class ByArtist : IComparer<Music>
{
    public int Compare(Music? x, Music? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Artist.CompareTo(y.Artist);
    }
}
class ByTitle : IComparer<Music>
{
    public int Compare(Music? x, Music? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Title.CompareTo(y.Title);
    }
}

class Music : IComparable
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }

    public int CompareTo(object? obj)
    {
        if (obj is null) return -1;
        if (obj is Music otherMusic) return this.Duration.CompareTo(otherMusic.Duration);
        return -1;

    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is Music otherMusic) return this.Title.Equals(otherMusic.Title) && this.Artist.Equals(otherMusic.Artist) && this.Duration.Equals(otherMusic.Duration);
        return false;
    }

    public override int GetHashCode()
    {
        return this.Title.GetHashCode() ^ this.Artist.GetHashCode() ^ this.Duration.GetHashCode();
    }
}

class Playlist : ICollection<Music>
{
    private HashSet<Music> hashTracks = new HashSet<Music>();
    private List<Music> tracks = new List<Music>();
    public string Name { get; set; }

    public int Count => tracks.Count;

    public bool IsReadOnly => false;

    public void Add(Music music)
    {
        if (hashTracks.Add(music))
        {
            tracks.Add(music);
        }
    }

    public void Clear()
    {
        tracks.Clear();
    }

    public bool Contains(Music music)
    {
        return tracks.Contains(music);
    }

    public Music? GetMusicByTitle(string title)
    {
        return tracks.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public Music? GetRandomMusic()
    {
        if (tracks.Count == 0) return null;
        return tracks[Random.Shared.Next(0, tracks.Count)];
    }

    public void OrderByDuration()
    {
        tracks.Sort();
    }
    public void OrderByArtist()
    {
        tracks.Sort(new ByArtist());
    }

    public void OrderByTitle()
    {
        tracks.Sort(new ByTitle());
    }

    public void CopyTo(Music[] array, int arrayIndex)
    {
        tracks.CopyTo(array, arrayIndex);
    }

    public IEnumerator<Music> GetEnumerator()
    {
        return tracks.GetEnumerator();
    }

    public bool Remove(Music music)
    {
        hashTracks.Remove(music);
        return tracks.Remove(music);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class MusicPlayer
{
    private Queue<Music> musicQueue = new Queue<Music>(); //FIFO
    private Stack<Music> musicStack = new Stack<Music>(); //LIFO

    public void AddMusicToQueue(Music music)
    {
        musicQueue.Enqueue(music);
    }

    public void AddMusicToQueue(Playlist playlist)
    {
        foreach (Music music in playlist)
        {
            musicQueue.Enqueue(music);
        }
    }

    public Music? NextQueueMusic()
    {
        if (musicQueue.Count == 0) return null;
        Music music = musicQueue.Dequeue();
        musicStack.Push(music);
        return music;
    }

    public Music? LastMusic()
    {
        if (musicStack.Count == 0) return null;
        Music music = musicStack.Pop();
        musicQueue.Enqueue(music);
        return music;
    }

    public IEnumerable<Music> Queue()
    {
        foreach (Music music in musicQueue)
        {
            yield return music;
        }
    }

    public IEnumerable<Music> History()
    {
        foreach (Music music in musicStack)
        {
            yield return music;
        }
    }
}