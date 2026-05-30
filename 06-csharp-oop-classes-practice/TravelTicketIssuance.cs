/*Travel Ticket Issuance

You are creating a ticket issuance system for a travel agency. Each ticket must strictly contain the passenger's name and the destination, defined at the time of creation.

Create a class called "Ticket" that has:
- A public property "Passenger".
- A public property "Destination".
- A constructor that forces these pieces of information to be provided when the object is created.

Then, create an instance of the class and display the ticket data.

Example Input:
Ticket ticket = new Ticket("Lucas Souza", "Paris");

Expected Output:
Passenger: Lucas Souza
Destination: Paris
*/

class Ticket
{
    public string Passenger { get; }
    public string Destination { get; }
    public Ticket(string passenger, string destination)
    {
        Passenger = passenger;
        Destination = destination;
    }
}

class Program
{
    static void Main()
    {
        Ticket ticket = new Ticket("Lucas Souza", "Paris");
        Console.WriteLine($"Passenger: {ticket.Passenger}");
        Console.WriteLine($"Destination: {ticket.Destination}");
    }
}