/*Content Evaluation using Polymorphism and Method Overriding

Imagine you are developing a course platform. In it, users can evaluate different types of content: recorded lessons or complementary materials.

These activities are treated as "Content", but each type has specific information:
- The recorded lesson has a duration in minutes.
- The complementary material has a number of pages.

Your mission is to:
- Create the base class "Content" with a "Title" property and the virtual method "DisplayInfo()".
- Create the classes "RecordedLesson" and "ComplementaryMaterial", overriding the "DisplayInfo()" method.
- Create a list of "Content" and, while iterating through it, display the specific information for each item.

Example Input:
List<Content> contents = new List<Content>
{
    new RecordedLesson("POO na prática", 45),
    new ComplementaryMaterial("Resumo do módulo 2", 12)
};

foreach (var content in contents)
{
    content.DisplayInfo();
}

Expected Output:
Title: POO na prática
Duration: 45 min
Title: Resumo do módulo 2
Pages: 12
*/

class Content
{
    public string Title { get; }
    public Content(string title)
    {
        Title = title;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
    }
}

class RecordedLesson : Content
{
    public int Duration { get; }
    public RecordedLesson(string title, int duration) : base(title)
    {
        Duration = duration;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Duration: {Duration} min");
    }
}

class ComplementaryMaterial : Content
{
    public int Pages { get; }
    public ComplementaryMaterial(string title, int pages) : base(title)
    {
        Pages = pages;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Pages: {Pages}");
    }
}

class Program
{
    static void Main()
    {
        List<Content> contents = new List<Content>
        {
            new RecordedLesson("POO na prática", 45),
            new ComplementaryMaterial("Resumo do módulo 2", 12)
        };
        foreach (var content in contents)
        {
            content.DisplayInfo();
        }
    }
}