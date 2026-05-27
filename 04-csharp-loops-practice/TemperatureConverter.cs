/*Temperature Converter

You are developing a temperature converter that allows the user to choose between two options: convert from Celsius to Fahrenheit or from Fahrenheit to Celsius. The program must display a menu with these options and repeat until the user chooses to exit.

To do this, you will need a program that:
- Displays a menu with the conversion and exit options.
- Allows the user to choose one of the options.
- Displays an "Invalid option" message if an option that does not exist is chosen.
- Performs the temperature conversion based on the user's choice.
- Repeats the menu until the user chooses to exit.

Tips:
Formula for converting Celsius to Fahrenheit: (celsius * 9 / 5) + 32
Formula for converting Fahrenheit to Celsius: (fahrenheit - 32) * 5 / 9

Example Input / Expected Output:

1 - Celsius to Fahrenheit
2 - Fahrenheit to Celsius
3 - Exit
Choose an option: 1
Enter the temperature in Celsius: 25
25°C is equivalent to 77°F
*/

int option;

do
{
    Console.WriteLine("1 - Celsius to Fahrenheit");
    Console.WriteLine("2 - Fahrenheit to Celsius");
    Console.WriteLine("3 - Exit");
    Console.Write("Choose an option: ");
    option = int.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 1:
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine()!);
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C is equivalent to {fahrenheit}°F");
            break;
        case 2:
            Console.Write("Enter the temperature in Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine()!);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit}°F is equivalent to {celsius}°C");
            break;
        case 3:
            Console.WriteLine("Exiting the program.");
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
} while (option != 3);