/*Computer Assembly using Composition

You are developing a system for a technical center specialized in assembling custom computers. Each computer is composed of different parts, and each part has its own characteristics. Instead of using inheritance, it makes more sense to compose a computer with these parts, since a computer has a motherboard, has a processor, and so on.

Your challenge is to create a structure that represents this assembly using composition.

Create a program that:
- Defines the "Processor" class, with the attributes "Brand" and "Model".
- Defines the "Motherboard" class, with the attributes "Manufacturer" and "Socket".
- Creates the "Computer" class, which has a "Processor" and a "Motherboard" as attributes.
- Instantiates objects of the parts with fictitious data and associates them with an object of the "Computer" class.
- Creates a method "DisplayConfiguration()" in the "Computer" class that displays the complete computer data on the console.

Example Input:
Processor cpu = new Processor("Intel", "i7-12700K");
Motherboard mobo = new Motherboard("ASUS", "LGA1700");
Computer pc = new Computer(cpu, mobo);

pc.DisplayConfiguration();

Expected Output:
Computer configured with:
Processor: Intel - i7-12700K
Motherboard: ASUS - LGA1700
*/

class Processor
{
    public string Brand { get; }
    public string Model { get; }
    public Processor(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }
}

class Motherboard
{
    public string Manufacturer { get; }
    public string Socket { get; }
    public Motherboard(string manufacturer, string socket)
    {
        Manufacturer = manufacturer;
        Socket = socket;
    }
}

class Computer
{
    public Processor Cpu { get; }
    public Motherboard Mobo { get; }
    public Computer(Processor cpu, Motherboard mobo)
    {
        Cpu = cpu;
        Mobo = mobo;
    }
    public void DisplayConfiguration()
    {
        Console.WriteLine("Computer configured with:");
        Console.WriteLine($"Processor: {Cpu.Brand} - {Cpu.Model}");
        Console.WriteLine($"Motherboard: {Mobo.Manufacturer} - {Mobo.Socket}");
    }
}

class Program
{
    static void Main()
    {
        Processor cpu = new Processor("Intel", "i7-12700K");
        Motherboard mobo = new Motherboard("ASUS", "LGA1700");
        Computer pc = new Computer(cpu, mobo);

        pc.DisplayConfiguration();
    }
}