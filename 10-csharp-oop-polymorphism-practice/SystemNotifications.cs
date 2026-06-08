/*System Notifications using Interfaces and Polymorphism

You are building a corporate alert application. To make the system easier to expand, you decide to create a structure where each notification channel (email, SMS, push, etc.) implements a common interface called "INotification".

Each type of notification must implement the "SendMessage(string message)" method in its own specific way. Then, you must create a list with different notification services and iterate through it, calling the send method.

Example Input:
List<INotification> notifications = new List<INotification>
{
    new EmailNotification(),
    new SmsNotification(),
    new PushNotification()
};

foreach (var notification in notifications)
{
    notification.SendMessage("System is down!");
}

Expected Output:
Sending EMAIL: System is down!
Sending SMS: System is down!
Sending PUSH: System is down!
*/

interface INotification
{
    void SendMessage(string message);
}

class EmailNotification : INotification
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending EMAIL: {message}");
    }
}

class SmsNotification : INotification
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}

class PushNotification : INotification
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending PUSH: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<INotification> notifications = new List<INotification>
        {
            new EmailNotification(),
            new SmsNotification(),
            new PushNotification()
        };
        foreach (var notification in notifications)
        {
            notification.SendMessage("System is down!");
        }
    }
}