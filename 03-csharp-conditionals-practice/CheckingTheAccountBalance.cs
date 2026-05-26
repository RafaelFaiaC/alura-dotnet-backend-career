/*Checking the Account Balance

Imagine you are developing a financial analysis system for a digital bank. As part of the features, you need to create a program that evaluates the status of a bank balance.

Create a program that:
- Receives a value representing the balance.
- Checks if this value is positive, negative, or zero.
- Displays a message indicating the status of the balance.

Example Input:
Enter the balance: -26.75

Expected Output:
The balance is negative.
*/

Console.Write("Enter the balance: ");
decimal balance = decimal.Parse(Console.ReadLine()!);

if (balance == 0)
{
    Console.WriteLine("The balance is zero.");

}
else if (balance > 0)
{
    Console.WriteLine("The balance is positive.");
}
else
{
    Console.WriteLine("The balance is negative.");
}