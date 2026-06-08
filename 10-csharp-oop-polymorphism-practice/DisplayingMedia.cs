/*Displaying Media using Polymorphism and Method Overriding

Imagine you are creating an online gallery system. In this gallery, users can browse through different types of media—such as images and videos. Each type of media must be displayed with an appropriate description, containing specific information like the image resolution or the video duration.

Your mission is to:
- Create the base class "Media" with the property "Name" and the virtual method "DisplayDetails()".
- Create the classes "Image" (with "Resolution") and "Video" (with "Duration"), overriding the "DisplayDetails()" method.
- Create a list with different media items and display the details of each one by calling "DisplayDetails()".

Example Input:
List<Media> mediaList = new List<Media>
{
    new Image("paisagem.jpg", "1920x1080"),
    new Video("filme.mp4", 120)
};

foreach (var media in mediaList)
{
    media.DisplayDetails();
}

Expected Output:
Image: paisagem.jpg - Resolution: 1920x1080
Video: filme.mp4 - Duration: 120 minutes
*/

class Media
{
    public string Name { get; }
    public Media(string name)
    {
        Name = name;
    }
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Media: {Name}");
    }
}

class Image : Media
{
    public string Resolution { get; }
    public Image(string name, string resolution) : base(name)
    {
        Resolution = resolution;
    }
    public override void DisplayDetails()
    {
        Console.WriteLine($"Image: {Name} - Resolution: {Resolution}");
    }
}

class Video : Media
{
    public int Duration { get; }
    public Video(string name, int duration) : base(name)
    {
        Duration = duration;
    }
    public override void DisplayDetails()
    {
        Console.WriteLine($"Video: {Name} - Duration: {Duration} minutes");
    }
}

class Program
{
    static void Main()
    {
        List<Media> mediaList = new List<Media>
        {
            new Image("paisagem.jpg", "1920x1080"),
            new Video("filme.mp4", 120)
        };

        foreach (var media in mediaList)
        {
            media.DisplayDetails();
        }
    }
}
