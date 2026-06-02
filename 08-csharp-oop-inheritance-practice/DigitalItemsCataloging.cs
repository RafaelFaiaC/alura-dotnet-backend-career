/*Digital Items Cataloging with Inheritance

Imagine you are developing a management system for a digital library. This system needs to organize different types of media, such as text documents and images, each with its own characteristics, but sharing basic properties.

Your task is to create a structure that allows cataloging these items, ensuring that each type of media can display its specific information.

Create a program that:
- Defines a base class called "DigitalItem" with an attribute to store the item's title.
- Creates a class "Scroll" that inherits from "DigitalItem", adding an attribute to store the textual content.
- Implements the method "DisplayDetails()" to display the title and content on the console.
- Instantiates an object of the class "Scroll", assigning a title and content.
- Calls the method "DisplayDetails()".

Example Input:
Scroll ancientScroll = new Scroll("Ancient_Secrets.txt", "The key to wisdom lies in observation...");

Expected Output:
Scroll Details:
Title: Ancient_Secrets.txt
Description: The key to wisdom lies in observation...
*/

class DigitalItem
{
    public string Title { get; set; }
    public DigitalItem(string title)
    {
        Title = title;
    }
}

class Scroll : DigitalItem
{
    public string Content { get; set; }
    public Scroll(string title, string content) : base(title)
    {
        Content = content;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Scroll Details:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Content}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Scroll ancientScroll = new Scroll("Ancient_Secrets.txt", "The key to wisdom lies in observation...");
        ancientScroll.DisplayDetails();
    }
}