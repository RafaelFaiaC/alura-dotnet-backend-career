/*Passenger Data with Inheritance

Imagine you are developing a system for a transportation company that needs to manage information about its passengers. Each registered person has basic data, such as name and age, but passengers can also report how many tickets they have already purchased. Your goal is to create a structure that organizes this information clearly and efficiently.

Create a program that:
- Defines a class "Person" with the attributes "Name" and "Age".
- Creates the class "Passenger", inheriting from "Person", and adds the attribute "TicketQuantity".
- Implements a method inside "Passenger" to display the formatted data on the console.
- Registers two passengers with fictitious data and displays their information.

Example Input:
Passenger p1 = new Passenger("Lúcia", 45, 3);  
Passenger p2 = new Passenger("Rodrigo", 30, 1);  

Expected Output:
Passenger: Lúcia - Age: 45 - Tickets: 3
Passenger: Rodrigo - Age: 30 - Tickets: 1
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

class Passenger : Person
{
    public int TicketQuantity { get; }
    public Passenger(string name, int age, int ticketQuantity) : base(name, age)
    {
        TicketQuantity = ticketQuantity;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Passenger: {Name} - Age: {Age} - Tickets: {TicketQuantity}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Passenger p1 = new Passenger("Lúcia", 45, 3);
        Passenger p2 = new Passenger("Rodrigo", 30, 1);

        p1.DisplayInfo();
        p2.DisplayInfo();
    }
}