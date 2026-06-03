/*Hotel Reservation System using Encapsulation

Imagine you are developing a system for a hotel that wants to organize its reservations. When making a reservation, it is necessary to associate a guest with a room, record the number of nights, and automatically calculate the total value of the stay. However, it is important to ensure that:
- The number of nights must be greater than zero.
- The room's daily rate must not be negative or zero.
- The system does not allow manual changes to the total value of the reservation.

You must ensure these rules using proper encapsulation, protecting the data and centralizing the verification and calculation logic within the classes themselves.

Create:
- "Guest" class:
  * Public property "Name", set in the constructor.
- "Room" class:
  * Public property "Number".
  * Property "DailyRate", with get and set, validating that the value is positive.
- "Reservation" class:
  * Private field "nights".
  * Read-only property "Guest" (object).
  * Read-only property "Room" (object).
  * Read-only property "TotalValue" (calculated).
  * Constructor that receives Guest, Room, and nights, and validates if the nights are greater than zero.

Example Input:
Guest guest = new Guest("Juliana Moura");
Room room = new Room(101);
room.DailyRate = 250;
Reservation reservation = new Reservation(guest, room, 3);

Expected Output:
Reservation for: Juliana Moura
Room: 101
Total value: $ 750.00
*/

class Guest
{
    public string Name { get; }
    public Guest(string name)
    {
        Name = name;
    }
}

class Room
{
    public int Number { get; }
    private decimal dailyRate;
    public decimal DailyRate
    {
        get { return dailyRate; }
        set
        {
            if (value <= 0)
                Console.WriteLine("Error: The daily rate must be greater than zero");
            dailyRate = value;
        }
    }
    public Room(int number)
    {
        Number = number;
    }
}

class Reservation
{
    private int nights;
    public Guest Guest { get; }
    public Room Room { get; }
    public decimal TotalValue => Room.DailyRate * nights;
    public Reservation(Guest guest, Room room, int nights)
    {
        if (nights <= 0)
            throw new ArgumentException("Number of nights must be greater than zero.");
        Guest = guest;
        Room = room;
        this.nights = nights;
    }
}

class Program
{
    static void Main()
    {
        Guest guest = new Guest("Juliana Moura");
        Room room = new Room(101);
        room.DailyRate = 250;

        Reservation reservation = new Reservation(guest, room, 3);

        Console.WriteLine($"Reservation for: {reservation.Guest.Name}");
        Console.WriteLine($"Room: {reservation.Room.Number}");
        Console.WriteLine($"Total value: $ {reservation.TotalValue:F2}");
    }
}