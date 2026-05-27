/*Inventory Control

Imagine you are responsible for the logistics department of an electronics store. Your first challenge is to create a system to record the entry of products into stock. Since the store receives merchandise daily, you need a tool that allows adding quantities agilely and shows the accumulated total, avoiding manual errors.

Create a program that:
- Asks the user if they want to record a new entry.
- If yes, requests the quantity and updates the stock.
- Repeats the process until the user decides to close.

Example Input:
Do you want to add a product to stock?
1 - Yes | 0 - No
1

Expected Output:
Quantity: 5
Current stock: 5
Do you want to continue? 1 - Yes | 0 - No
1
Quantity: 10
Current stock: 15
Do you want to continue? 1 - Yes | 0 - No
0
Thank you for using our inventory system!
*/

int stock = 0;

Console.Write("Do you want to add a product to stock? (1 - Yes | 0 - No): ");
int option = int.Parse(Console.ReadLine()!);

while (option == 1)
{
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine()!);
    stock += quantity;

    Console.WriteLine($"\nCurrent stock: {stock}\n");

    Console.Write("Do you want to continue? (1 - Yes | 0 - No): ");
    option = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("\nThank you for using our inventory system!");