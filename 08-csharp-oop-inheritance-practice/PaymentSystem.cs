/*Payment System combining Inheritance and Interfaces

You are developing a system to process different types of payment in an online store. Each payment is made by a person (customer), but the type of transaction varies: it can be via credit card, bank slip (boleto), or another method.

The system must ensure that every type of payment executes a method called "ProcessPayment()", but each with a different logic. Additionally, the people involved in the transaction share common data.

Your challenge is to combine inheritance (to model the people) and interfaces (to standardize the payment methods).

Create a program that:
- Defines a base class "Person" with the attributes "Name" and "Email".
- Creates an interface "IPayment" with the method "ProcessPayment()".
- Creates two classes:
  * "CreditPayment": which inherits from "Person" and implements "IPayment".
  * "BoletoPayment": which also inherits from "Person" and implements "IPayment".
- In each payment class, personalize the "ProcessPayment()" method with a different message.
- Instantiates a customer for each type of payment and calls the "ProcessPayment()" method.

Example Input:
CreditPayment client1 = new CreditPayment("André", "andre@email.com");
BoletoPayment client2 = new BoletoPayment("Juliana", "juliana@email.com");

client1.ProcessPayment();
client2.ProcessPayment();

Expected Output:
Processing credit card payment for André - andre@email.com
Processing bank slip payment for Juliana - juliana@email.com
*/

class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Person(string name, string email)
    {
        Name = name;
        Email = email;
    }
}

interface IPayment
{
    void ProcessPayment();
}

class CreditPayment : Person, IPayment
{
    public CreditPayment(string name, string email) : base(name, email) { }
    public void ProcessPayment()
    {
        Console.WriteLine($"Processing credit card payment for {Name} - {Email}");
    }
}

class BoletoPayment : Person, IPayment
{
    public BoletoPayment(string name, string email) : base(name, email) { }
    public void ProcessPayment()
    {
        Console.WriteLine($"Processing bank slip payment for {Name} - {Email}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CreditPayment client1 = new CreditPayment("André", "andre@email.com");
        BoletoPayment client2 = new BoletoPayment("Juliana", "juliana@email.com");

        client1.ProcessPayment();
        client2.ProcessPayment();
    }
}