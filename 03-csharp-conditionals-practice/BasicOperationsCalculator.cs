/*Basic Operations Calculator

You need to build a mini-calculator that performs a mathematical operation with two numbers. The user must type the first number, the second number, and which operation they wish to perform: addition (+), subtraction (-), multiplication (*), or division (/). Based on the entered operation, the program must calculate and display the result.

Create a program that:
- Receives two numbers typed by the user.
- Asks which mathematical operation they wish to perform (+, -, *, /).
- Displays "Invalid operation" if the input is different from the operations above.
- Displays the result according to the chosen operation.

Example Input:
Enter the first number: 5
Enter the second number: 5
Enter the operation (+, -, *, /): *

Expected Output:
Result: 25
*/

Console.Write("Enter the first number: ");
double firstNumber = double.Parse(Console.ReadLine()!);

Console.Write("Enter the second number: ");
double secondNumber = double.Parse(Console.ReadLine()!);

Console.Write("Enter the operation (+, -, *, /): ");
string operation = Console.ReadLine()!;

switch (operation)
{
    case "+":
        Console.WriteLine($"Result: {firstNumber + secondNumber}");
        break;
    case "-":
        Console.WriteLine($"Result: {firstNumber - secondNumber}");
        break;
    case "*":
        Console.WriteLine($"Result: {firstNumber * secondNumber}");
        break;
    case "/":
        if (secondNumber != 0)
            Console.WriteLine($"Result: {firstNumber / secondNumber}");
        else
            Console.WriteLine("Cannot divide by zero.");
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}
