/*VIP Client System with Inheritance

You are developing a system for a club, where customer experience is a priority. Regular members have basic access, but VIP clients have exclusive benefits, such as loyalty levels and personalized identifiers. Your challenge is to create a structure that differentiates these profiles.

Create a program that:
- Defines a class "Person" with the attributes "Name" and "Age".
- Creates a class "VIPClient" that inherits from "Person", adding:
  * A loyalty level attribute (e.g., Gold, Diamond).
  * A VIP code attribute (e.g., VIP123A).
- Instantiates two VIP clients with fictitious data.
- Displays a formatted message on the console for each client, including:
  * A personalized greeting (e.g., "Welcome, VIP client: [Name]").
  * Age, loyalty level, and VIP code on separate lines.

Example Input:
VIPClient client1 = new VIPClient("Renata", 32, "Gold", "VIP123A");  
VIPClient client2 = new VIPClient("Leonardo", 40, "Diamond", "VIP789X");  

Expected Output:
Welcome, VIP client: Renata
Age: 32
Loyalty Level: Gold
VIP Code: VIP123A

Welcome, VIP client: Leonardo
Age: 40
Loyalty Level: Diamond
VIP Code: VIP789X
*/

class Person
{
    public string Name { get; }
    public int Age { get; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class VIPClient : Person
{
    public string LoyaltyLevel { get; }
    public string VIPCode { get; }
    public VIPClient(string name, int age, string loyaltyLevel, string vipCode) : base(name, age)
    {
        LoyaltyLevel = loyaltyLevel;
        VIPCode = vipCode;
    }
}

class Program
{
    static void Main(string[] args)
    {
        VIPClient client1 = new VIPClient("Renata", 32, "Gold", "VIP123A");
        VIPClient client2 = new VIPClient("Leonardo", 40, "Diamond", "VIP789X");

        Console.WriteLine($"Welcome, VIP client: {client1.Name}");
        Console.WriteLine($"Age: {client1.Age}");
        Console.WriteLine($"Loyalty Level: {client1.LoyaltyLevel}");
        Console.WriteLine($"VIP Code: {client1.VIPCode}\n");

        Console.WriteLine($"Welcome, VIP client: {client2.Name}");
        Console.WriteLine($"Age: {client2.Age}");
        Console.WriteLine($"Loyalty Level: {client2.LoyaltyLevel}");
        Console.WriteLine($"VIP Code: {client2.VIPCode}");
    }
}

