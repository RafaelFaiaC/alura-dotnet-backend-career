/*Sum of Sales

Imagine a clothing store hired you to create a simple system to help record and sum daily sales values. The store does not have an automated checkout system, so employees need to manually type the value of each sale at the end of the day. The challenge is to create a program that allows continuous entry of these values until the user types "0", indicating that all sales for the day have been recorded.

Create a program that:
- Prompts the user to type the value of each sale (integer).
- As long as the entered value is different from "0", the program adds the value to the accumulated total. The value needs to be requested at least once before checking whether the loop should continue or not.
- When the user types "0", the program terminates the loop and displays the total sales for the day.

Example Input:
Enter the sale value (or 0 to end): 15
Enter the sale value (or 0 to end): 20
Enter the sale value (or 0 to end): 25
Enter the sale value (or 0 to end): 30
Enter the sale value (or 0 to end): 0

Expected Output:
Total sales for the day: R$90
*/

double totalSales = 0;
double saleValue;
do
{
    Console.Write("Enter the sale value (or 0 to end): ");
    saleValue = double.Parse(Console.ReadLine()!);
    totalSales += saleValue;
} while (saleValue != 0);

Console.WriteLine($"Total sales for the day: R${totalSales:F2}");