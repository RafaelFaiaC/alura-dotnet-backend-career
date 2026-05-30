/*Inventory Control

You have been given the mission to automate the inventory system for a stationery store. Each item must record its name and the current quantity in stock. The system must allow items to be withdrawn, but only if there is a sufficient quantity available. Otherwise, it must display a message indicating the failure.

Create a class called "Product" with:
- A public property "Name".
- A private field "stockQuantity".
- A constructor that receives the name and the initial quantity.
- A public method "Withdraw(int quantity)" that:
  * Reduces the quantity only if there is sufficient stock.
  * Displays a message indicating the success or failure of the operation.
- A method "DisplayInventory()" to show the current quantity.

Example Input:
Product product = new Product("Blue Pen", 20);
product.Withdraw(5);
product.DisplayInventory();
product.Withdraw(30);

Expected Output:
Withdrawal of 5 units carried out successfully.
Product: Blue Pen
Stock: 15
Error: Insufficient stock for withdrawal of 30 units.
*/

class Product
{
    public string Name { get; }
    private int stockQuantity;
    public Product(string name, int initialQuantity)
    {
        Name = name;
        stockQuantity = initialQuantity;
    }
    public void Withdraw(int quantity)
    {
        if (quantity <= stockQuantity)
        {
            stockQuantity -= quantity;
            Console.WriteLine($"Withdrawal of {quantity} units carried out successfully.");
        }
        else
        {
            Console.WriteLine($"Error: Insufficient stock for withdrawal of {quantity} units.");
        }
    }
    public void DisplayInventory()
    {
        Console.WriteLine($"Product: {Name}");
        Console.WriteLine($"Stock: {stockQuantity}");
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product("Blue Pen", 20);
        product.Withdraw(5);
        product.DisplayInventory();
        product.Withdraw(30);
    }
}