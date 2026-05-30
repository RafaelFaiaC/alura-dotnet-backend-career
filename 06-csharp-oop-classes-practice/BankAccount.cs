/*BankAccount Class Creation

You were hired to develop a banking operations system. Each account must have an account number and an initial balance. Also, there must be a method to perform deposits, receiving the amount to be deposited as a parameter.

Create a class called "BankAccount" that has:
- A public property "AccountNumber".
- A public property "Balance".
- A method "Deposit(double amount)" that adds the amount to the existing balance.

Then, create an instance of the class, perform a deposit, and display the updated balance.

Example Input:
BankAccount account = new BankAccount("78901-2", 1000.00);
account.Deposit(500.00);

Expected Output:
Account: 78901-2
Current Balance: $ 1,500.00
*/

class BankAccount
{
    public string AccountNumber { get; }
    public double Balance { get; private set; }
    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }
    public void Deposit(double amount)
    {
        Balance += amount;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("78901-2", 1000.00);
        account.Deposit(500.00);
        Console.WriteLine($"Account: {account.AccountNumber}");
        Console.WriteLine($"Current Balance: $ {account.Balance:F2}");
    }
}