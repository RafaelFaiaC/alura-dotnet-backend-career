/*Devices with Sensors using Interfaces

You are developing a system for monitoring smart sensors in different electronic devices. Each device can activate or deactivate sensors, but the types of sensors vary depending on the model.

Your challenge is to create a structure that ensures all devices implement a standard behavior. To do this, we will use interfaces.

Create a program that:
- Defines an interface "ISensor" with the methods "Activate()" and "Deactivate()".
- Creates a class "TemperatureSensor" that implements the interface "ISensor".
- Creates a class "PresenceSensor" that also implements the interface "ISensor".
- For each type of sensor, displays a personalized message on the console upon activation and deactivation.
- In Program.cs, instantiates each sensor and calls the "Activate()" and "Deactivate()" methods.

Example Input:
TemperatureSensor temp = new TemperatureSensor();
PresenceSensor presence = new PresenceSensor();

temp.Activate();
temp.Deactivate();

presence.Activate();
presence.Deactivate();

Expected Output:
Temperature sensor activated.
Temperature sensor deactivated.
Presence sensor activated.
Presence sensor deactivated.
*/

interface ISensor
{
    void Activate();
    void Deactivate();
}

class TemperatureSensor : ISensor
{
    public void Activate()
    {
        Console.WriteLine("Temperature sensor activated.");
    }
    public void Deactivate()
    {
        Console.WriteLine("Temperature sensor deactivated.");
    }
}

class PresenceSensor : ISensor
{
    public void Activate()
    {
        Console.WriteLine("Presence sensor activated.");
    }
    public void Deactivate()
    {
        Console.WriteLine("Presence sensor deactivated.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TemperatureSensor temp = new TemperatureSensor();
        PresenceSensor presence = new PresenceSensor();

        temp.Activate();
        temp.Deactivate();

        presence.Activate();
        presence.Deactivate();
    }
}