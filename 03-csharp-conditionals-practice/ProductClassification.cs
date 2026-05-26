/*Product Classification

Imagine you are developing an inventory management system for a food distribution center. Your challenge is to create a program that classifies products according to their type to optimize storage in specific areas of the warehouse.

Create a program that:
- Receives a numeric code (1 or 2) representing the product type.
- Classifies the product as "Perishable" for code 1.
- Classifies the product as "Non-perishable" for code 2.
- Alerts the user if the code is invalid.

Example Input:
Enter the product code (1 or 2): 1

Expected Output:
Perishable
*/

Console.Write("Enter the product code (1 or 2): ");
int productCode = int.Parse(Console.ReadLine()!);

if (productCode == 1)
{
    Console.WriteLine("Perishable");

}
else if (productCode == 2)
{
    Console.WriteLine("Non-perishable");
}
else
{
    Console.WriteLine("Invalid code. Please enter 1 or 2.");
}