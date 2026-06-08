/*Experience Reservations using Polymorphism and Method Overriding

You are developing a reservation system for a tourism agency. Customers can book in-person tours, such as trails and city tours, or online experiences, such as virtual cooking or photography workshops.

The system treats all reservations as "Reservation", but each type has a different process when confirmed:
- The in-person reservation must provide the meeting point.
- The online reservation must send an access link.

Your mission is to:
- Create the base class "Reservation", with a virtual method "Confirm()".
- Create the classes "InPersonReservation" and "OnlineReservation", which override this method.
- Create a list with different types of reservations and process them in a foreach loop, calling "Confirm()".

Example Input:
List<Reservation> reservations = new List<Reservation>
{
    new InPersonReservation("Trilha na Serra"),
    new OnlineReservation("Workshop de Culinária Italiana")
};

foreach (var reservation in reservations)
{
    reservation.Confirm();
}

Expected Output:
Confirming in-person reservation: Trilha na Serra
Meeting point: Central Square, at 8 AM
Confirming online reservation: Workshop de Culinária Italiana
Access link sent by email!
*/

class Reservation
{
    public string Name { get; set; }
    public Reservation(string name)
    {
        Name = name;
    }
    public virtual void Confirm()
    {
        Console.WriteLine($"Confirming reservation: {Name}");
    }
}

class InPersonReservation : Reservation
{
    public InPersonReservation(string name) : base(name) { }
    public override void Confirm()
    {
        Console.WriteLine($"Confirming in-person reservation: {Name}");
        Console.WriteLine("Meeting point: Central Square, at 8 AM");
    }
}

class OnlineReservation : Reservation
{
    public OnlineReservation(string name) : base(name) { }
    public override void Confirm()
    {
        Console.WriteLine($"Confirming online reservation: {Name}");
        Console.WriteLine("Access link sent by email!");
    }
}

class Program
{
    static void Main()
    {
        List<Reservation> reservations = new List<Reservation>
        {
            new InPersonReservation("Trilha na Serra"),
            new OnlineReservation("Workshop de Culinária Italiana")
        };
        foreach (var reservation in reservations)
        {
            reservation.Confirm();
        }
    }
}