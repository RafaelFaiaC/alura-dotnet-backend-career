using System.Text.Json.Serialization;

namespace ScreenSound.Models;

internal class Music
{
    [JsonPropertyName("artist")]
    public string Artist { get; set; }
    [JsonPropertyName("song")]
    public string Title { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }
    [JsonPropertyName("genre")]
    public string Genre { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }

    public static readonly string[] KeyValues =
        { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

    public void DisplayMusicInfo()
    {
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Duration: {Duration / 1000} s");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Key: {KeyValues[Key]}");
    }
}
