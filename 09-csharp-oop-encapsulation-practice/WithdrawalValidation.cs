/*Withdrawal Validation using Encapsulation and Internal Access

Imagine you are developing a banking application and need to encapsulate the behavior of a cash withdrawal. For security reasons, the withdrawal validation logic cannot stay inside the account class itself, but must be delegated to an internal security class responsible for validating the allowed limits for the operation.

Create:
- A class "BankAccount" with:
  * Public property "Holder".
  * Private field "balance".
  * Constructor to set the holder and initial balance.
  * Public method "Withdraw(double amount)" that only performs the withdrawal if the internal security class allows it.
  * Read-only property "Balance" (get only).
- A class "AccountSecurity" (with internal modifier) with:
  * A method "ValidateWithdrawal(double amount)" that only authorizes withdrawals up to $ 1,000.

Example Input:
BankAccount account = new BankAccount("Carlos Silva", 2500);
account.Withdraw(1500); // Invalid
account.Withdraw(800);  // Valid

Expected Output:
Withdrawal denied by security policy.
Withdrawal completed successfully.
Current balance: $ 1,700.00
*/

class BankAccount
{
    public string Holder { get; private set; }
    private double balance;
    private AccountSecurity security;
    public BankAccount(string holder, double initialBalance)
    {
        Holder = holder;
        balance = initialBalance;
        security = new AccountSecurity();
    }
    public void Withdraw(double amount)
    {
        if (security.ValidateWithdrawal(amount))
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal completed successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal denied by security policy.");
        }
    }
    public double Balance => balance;
}

class AccountSecurity
{
    internal bool ValidateWithdrawal(double amount)
    {
        return amount <= 1000;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("Carlos Silva", 2500);
        account.Withdraw(1500); // Invalid
        account.Withdraw(800);  // Valid

        Console.WriteLine($"Current balance: $ {account.Balance:F2}");
    }
}