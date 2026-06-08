/*Urban Transport Simulator using Polymorphism and Method Overriding

You are developing a simulator for an urban mobility application. Users can choose different modes of transport to calculate the estimated time of arrival at their destination. The calculation changes according to the type of transport used:
- Bus: estimated time = (distance × 2) + 5 minutes
- Subway: estimated time = distance + 5 minutes
- Bicycle: estimated time = distance × 4 minutes

Your mission is to:
- Create the base class "Transport", with the virtual method "CalculateTime(int distanceKm)" that returns an int (minutes).
- Create the classes "Bus", "Subway", and "Bicycle", overriding this method with their respective rules.
- Create a list with different modes of transport and display the estimated time for each one.

Example Input:
List<Transport> options = new List<Transport>
{
    new Bus(),
    new Subway(),
    new Bicycle()
};

int distance = 10;

foreach (var transport in options)
{
    Console.WriteLine($"{transport.GetType().Name}: {transport.CalculateTime(distance)} min");
}

Expected Output:
Bus: 25 min  
Subway: 15 min  
Bicycle: 40 min
*/

class Transport
{
    public virtual int CalculateTime(int distanceKm)
    {
        return 0;
    }
}

class Bus : Transport
{
    public override int CalculateTime(int distanceKm)
    {
        return (distanceKm * 2) + 5;
    }
}

class Subway : Transport
{
    public override int CalculateTime(int distanceKm)
    {
        return distanceKm + 5;
    }
}

class Bicycle : Transport
{
    public override int CalculateTime(int distanceKm)
    {
        return distanceKm * 4;
    }
}

class Program
{
    static void Main()
    {
        List<Transport> options = new List<Transport>
        {
            new Bus(),
            new Subway(),
            new Bicycle()
        };
        int distance = 10;
        foreach (var transport in options)
        {
            Console.WriteLine($"{transport.GetType().Name}: {transport.CalculateTime(distance)} min");
        }
    }
}
