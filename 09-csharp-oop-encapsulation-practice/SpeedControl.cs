/*Speed Control using Encapsulation

You are creating a vehicle monitoring system for a transportation company. The "Vehicle" class needs to control the current speed, but the company wants to ensure that no one can directly change this value to prevent fraud. The value can only be changed through an authorized method.

Create a class called "Vehicle" that has:
- A public property "LicensePlate" (or "Placa").
- A private field "currentSpeed" (or "velocidadeAtual").
- A public method "UpdateSpeed(double newSpeed)" that updates the speed.
- A public read-only property (get) called "CurrentSpeed" that returns the current speed.

Example Input:
Vehicle vehicle = new Vehicle("ABC-1234");
vehicle.UpdateSpeed(72.5);

Expected Output:
Vehicle: ABC-1234
Current speed: 72.5 km/h
*/

public class Vehicle
{
    public string LicensePlate { get; }
    private double currentSpeed;
    public Vehicle(string licensePlate)
    {
        LicensePlate = licensePlate;
        currentSpeed = 0.0;
    }
    public void UpdateSpeed(double newSpeed)
    {
        currentSpeed = newSpeed;
    }
    public double CurrentSpeed => currentSpeed;
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle("ABC-1234");
        vehicle.UpdateSpeed(72.5);

        Console.WriteLine($"Vehicle: {vehicle.LicensePlate}");
        Console.WriteLine($"Current speed: {vehicle.CurrentSpeed} km/h");
    }
}