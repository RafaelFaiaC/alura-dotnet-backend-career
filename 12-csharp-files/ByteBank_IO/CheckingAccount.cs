namespace ByteBank_IO;

internal class CheckingAccount
{
    public int Number { get; }
    public int Branch { get; }
    public decimal Balance { get; private set; }
    public Customer Holder { get; set; }

    public CheckingAccount(int number, int branch)
    {
        Number = number;
        Branch = branch;
    }

    public void Deposit(decimal value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("The deposit amount must be greater than zero.");
        }
        Balance += value;
    }

    public void Withdraw(decimal value)
    {
        if (value <= 0)
        {
            Console.WriteLine("The withdrawal amount must be greater than zero.");
        }
        if (value > Balance)
        {
            Console.WriteLine("Insufficient funds for this withdrawal.");
        }
        Balance -= value;
    }
}
