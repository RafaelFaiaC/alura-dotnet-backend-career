/*How Many Odd Numbers Were Entered?

You are developing a data analysis tool that allows the user to enter 10 integers, one at a time. The goal is to count how many of these numbers are odd and, at the end, display the total number of odd numbers entered.

To do this, you will need a program that:
- Prompts the user to enter 10 integers.
- Checks, for each number, if it is odd.
- Counts how many odd numbers were entered.
- Displays the total number of odd numbers at the end.

Example Input:
Enter a number: 2
Enter a number: 3
Enter a number: 5
Enter a number: 7
Enter a number: 10
Enter a number: 12
Enter a number: 15
Enter a number: 17
Enter a number: 20
Enter a number: 21

Expected Output:
You entered 6 odd numbers.
*/
int oddCount = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine()!);
    if (number % 2 != 0)
    {
        oddCount++;
    }
}
Console.WriteLine($"You entered {oddCount} odd numbers.");