namespace ScreenSound;

internal class Episode
{
    List<string> guests = new List<string>();
    public int Number { get; }
    public string Title { get; }
    public int Duration { get; }
    public string Summary => $"{Number} - {Title} with {string.Join(", ", guests)} (Duration: {Duration / 60} min)";

    public Episode(int number, string title, int duration)
    {
        Number = number;
        Title = title;
        Duration = duration;
    }

    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }


}