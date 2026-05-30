/*Representing a Purchase Order

Imagine you are developing an order system for an online store. Every time someone makes a purchase, the system needs to record the order number, the customer's name, and the current status (for example: "Pending", "Shipped", "Delivered").

Your role is to represent this order as a class, with its main attributes and a behavior: allowing the status to be updated as the order progresses.

Create a class called "Order" with:
- A public property "OrderNumber" (string).
- A public property "CustomerName" (string).
- A public property "Status" (string).
- A method called "UpdateStatus(string newStatus)" to change the status.
- A method called "DisplayOrder()" that shows the data on the screen.

Example Input:
Order order = new Order("001", "Ana Silva", "Pending");
order.DisplayOrder();
order.UpdateStatus("Shipped");
order.DisplayOrder();

Expected Output:
Order No. 001
Customer: Ana Silva
Status: Pending

Order No. 001
Customer: Ana Silva
Status: Shipped
*/

class Order
{
    public string OrderNumber { get; }
    public string CustomerName { get; }
    public string Status { get; private set; }
    public Order(string orderNumber, string customerName, string initialStatus)
    {
        OrderNumber = orderNumber;
        CustomerName = customerName;
        Status = initialStatus;
    }
    public void UpdateStatus(string newStatus)
    {
        Status = newStatus;
    }
    public void DisplayOrder()
    {
        Console.WriteLine($"Order No. {OrderNumber}");
        Console.WriteLine($"Customer: {CustomerName}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Order order = new Order("001", "Ana Silva", "Pending");
        order.DisplayOrder();
        order.UpdateStatus("Shipped");
        order.DisplayOrder();
    }
}