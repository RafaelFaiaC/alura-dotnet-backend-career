using var fileStream = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var streamReader = new StreamReader(fileStream);

var tracks = GetTracks(streamReader)
    .Take(20);

DisplayTracksInTable(tracks);

void Interning()
{
    var artist1 = "coldplay"; // Interned string literal
    var artist2 = "coldplay";
    var artist3 = new string("coldplay"); // don't use this way to create a string, it will create a new instance of the string in memory (don't use interned strings)
    var artist4 = "COLDPLAY"; // Interned string literal
    var artist5 = artist1.ToUpper(); // Use HEAP
    var artist6 = string.Intern(artist1.ToUpper());

    Console.WriteLine(artist1 == artist2); //True
    Console.WriteLine(ReferenceEquals(artist1, artist2)); //True - Use the pool of strings
    Console.WriteLine(ReferenceEquals(artist1, artist3)); //False - Different instances
    Console.WriteLine(ReferenceEquals(artist1, artist4)); //False - Different instances
    Console.WriteLine(ReferenceEquals(artist4, artist5)); //False - Different instances
    Console.WriteLine(ReferenceEquals(artist5, artist6)); //True - Same instance after interning
}

void ComparingStrings(StreamReader streamReader)
{
    var track = GetTracks(streamReader)
    .Where(m => m.Artist.Equals("COLDPLAY", StringComparison.OrdinalIgnoreCase))
    .Take(20);

    // Methods that use StringComparison
    "Coldplay".Equals("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".StartsWith("cold", StringComparison.OrdinalIgnoreCase);
    "Coldplay".EndsWith("PLAY", StringComparison.OrdinalIgnoreCase);
    "Coldplay".IndexOf("PLAY", StringComparison.OrdinalIgnoreCase);
    "Coldplay".Contains("OLD", StringComparison.OrdinalIgnoreCase);
    "Coldplay".Replace("cold","warm", StringComparison.OrdinalIgnoreCase);

    DisplayTracksInTable(track);
}

void ChangingTitle(StreamReader streamReader)
{
    var track = GetTracks(streamReader)
    .Where(m => m.Title.StartsWith('T'))
    .FirstOrDefault()!;

    //Console.WriteLine("Track title: " + track.Title); //traditional concatenation
    Console.WriteLine($"Track title: {track.Title}"); //string interpolation
    track.Title = track.Title.Replace("The ", ""); //immutability
                                                   //track.Title = track.Title.ToUpper(); 
    Console.WriteLine($"Track title: {track.Title}");
}

void passwordValidation()
{

    //char[] letters; //This is a string of characters

    //var title = "Tracks in file";
    //foreach (var letter in title)
    //{
    //    Console.WriteLine(letter);
    //}

    var password = "Rafael123#";

    /*
        Password will be strong if:
        0. has at least 8 characters
        1. has some uppercase letter
        2. has some lowercase letter
        3. has some number
        4. has some symbol
    */

    var totalOfLetters = password.Length;
    var hasUppercaseLetter = password.Any(l => char.IsUpper(l));
    var hasLowercaseLetter = password.Any(l => char.IsLower(l));
    var hasNumber = password.Any(l => char.IsDigit(l));
    var hasSymbol = password.Any(l => !char.IsLetterOrDigit(l));

    if (totalOfLetters >= 8 && hasUppercaseLetter && hasLowercaseLetter && hasNumber && hasSymbol)
    {
        Console.WriteLine("The password is strong!");
    }
    else
    {
        Console.WriteLine("The password is weak!");
    }
}

void DisplayTracks(IEnumerable<Music> tracks)
{
    var title = "\nTracks in file:"; // literal string
    //var title = new string("\nTracks in the file:");

    Console.WriteLine(title);
    foreach (var track in tracks)
    {
        Console.WriteLine($"- {track.Title} ({track.Artist}) - {track.Duration} seconds | [{track.ReleaseDate}] ");
    }
}

void DisplayTracksInTable(IEnumerable<Music> tracks)
{
    var title = "\nTracks in file:"; // literal string
    Console.WriteLine(title);

    var columnTitle = "Title".PadRight(40);
    var columnArtist = "Artist".PadRight(30);
    var columnDuration = "Duration".PadRight(10);
    var columnReleaseDate = "Release Date".PadRight(15);
    Console.WriteLine($"{columnTitle}{columnArtist}{columnDuration}{columnReleaseDate}");

    var border = string.Empty.PadRight(100, '=');
    Console.WriteLine(border);

    foreach (var track in tracks)
    {
        Console.WriteLine($"{track.Title,-40}{track.Artist,-30}{track.Duration / 60.0,-10:F2}{track.ReleaseDate,-15:dd/MM/yyyy}");
    }
}

IEnumerable<Music> GetTracks(StreamReader streamReader)
{
    var line = streamReader.ReadLine();
    while (line is not null)
    {
        var fields = line.Split(';');
        var title = string.IsNullOrWhiteSpace(fields[0]) ? "Unknown Title" : fields[0];
        var artist = string.IsNullOrWhiteSpace(fields[1]) ? "Unknown Artist" : fields[1];
        var duration = int.TryParse(fields[2], out int dur) ? dur : 0;
        var genre = fields[3].Split(',', StringSplitOptions.TrimEntries);
        var releaseDate = DateTime.TryParse(fields[4], out DateTime date) ? date : DateTime.MinValue;
        var music = new Music(title, artist, duration, genre, releaseDate);
        yield return music;
        line = streamReader.ReadLine();
    }
}

class Music
{
    public Music(string title, string artist, int duration, IEnumerable<string> genre, DateTime releaseDate)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
        Genre = genre;
        ReleaseDate = releaseDate;
    }

    public string Title { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public IEnumerable<string> Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
}