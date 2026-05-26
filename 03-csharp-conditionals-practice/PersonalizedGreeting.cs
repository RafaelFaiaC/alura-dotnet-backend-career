/*Personalized Greeting

You work on the development of Lura AI, a virtual assistant for a customer service system. It needs to personalize its messages according to the time of day to make the interaction more friendly and natural.

To do this, you need a program that:
- Asks the user what time of day it is (morning, afternoon, or night).
- Requests the user's name.
- Displays a personalized greeting based on the time of day and the name provided.
- Displays a message in case of an invalid option.

Example Input:
1 - Morning
2 - Afternoon
3 - Night

What time of day is it now? 2

What is your name? Mike

Expected Output:
Good afternoon, Mike.
*/

Console.WriteLine("1 - Morning");
Console.WriteLine("2 - Afternoon");
Console.WriteLine("3 - Night");

Console.Write("What time of day is it now? ");
int timeOfDay = int.Parse(Console.ReadLine()!);

Console.Write("What is your name? ");
string name = Console.ReadLine()!;

switch (timeOfDay)
{
    case 1:
        Console.WriteLine($"Good morning, {name}.");
        break;
    case 2:
        Console.WriteLine($"Good afternoon, {name}.");
        break;
    case 3:
        Console.WriteLine($"Good night, {name}.");
        break;
    default:
        Console.WriteLine("Invalid option. Please select 1, 2, or 3.");
        break;
}