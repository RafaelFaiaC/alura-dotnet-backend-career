/*Modeling a Digital Product with Technical Information

You need to create a system for a software store. Each digital product has a name, a price, and technical details, such as the file size and the compatible operating system. These technical details can vary a lot and, therefore, make more sense in a separate structure — a class just for that.

Create:
- A class "TechnicalInformation" with:
  * Properties "SizeMB" and "OperatingSystem".
- A class "DigitalProduct" with:
  * Properties "Name", "Price", and "TechInfo" (of type TechnicalInformation).
- A method "DisplayDetails()" to show everything on the screen.

Example Input:
TechnicalInformation info = new TechnicalInformation(1500, "Windows/Mac");
DigitalProduct product = new DigitalProduct("Photoshop", 89.99, info);
product.DisplayDetails();

Expected Output:
Product: Photoshop
Price: $ 89.99
Size: 1500MB
Compatible with: Windows/Mac
*/

class TechnicalInformation
{
    public int SizeMB { get; }
    public string OperatingSystem { get; }
    public TechnicalInformation(int sizeMB, string operatingSystem)
    {
        SizeMB = sizeMB;
        OperatingSystem = operatingSystem;
    }
}

class DigitalProduct
{
    public string Name { get; }
    public double Price { get; }
    public TechnicalInformation TechInfo { get; }
    public DigitalProduct(string name, double price, TechnicalInformation techInfo)
    {
        Name = name;
        Price = price;
        TechInfo = techInfo;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Product: {Name}");
        Console.WriteLine($"Price: $ {Price:F2}");
        Console.WriteLine($"Size: {TechInfo.SizeMB}MB");
        Console.WriteLine($"Compatible with: {TechInfo.OperatingSystem}");
    }
}

class Program
{
    static void Main()
    {
        TechnicalInformation info = new TechnicalInformation(1500, "Windows/Mac");
        DigitalProduct product = new DigitalProduct("Photoshop", 89.99, info);
        product.DisplayDetails();
    }
}