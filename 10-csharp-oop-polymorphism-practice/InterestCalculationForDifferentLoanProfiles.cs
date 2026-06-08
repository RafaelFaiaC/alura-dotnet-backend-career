/*Interest Calculation for Different Loan Profiles using Interfaces and Polymorphism

You are developing a loan simulator for a fintech company. The system needs to calculate the final value of a loan based on different customer profiles, each with a distinct monthly interest rate.

The calculation must follow the simple interest formula:
FinalValue = LoanAmount + (LoanAmount × Rate × Months)

The rates are:
- Student: 1% per month
- BusinessOwner: 2.5% per month
- Retiree: 1.5% per month

Your mission is to:
- Create an interface "ILoan" with the method "CalculateFinalValue(decimal amount, int months)".
- Create the classes "StudentLoan", "BusinessOwnerLoan", and "RetireeLoan" that implement this interface.
- Simulate the final value of a $1,000 loan for 12 months for each profile.

Example Input:
List<ILoan> profiles = new List<ILoan>
{
    new StudentLoan(),
    new BusinessOwnerLoan(),
    new RetireeLoan()
};

foreach (var profile in profiles)
{
    decimal total = profile.CalculateFinalValue(1000m, 12);
    Console.WriteLine($"{profile.GetType().Name}: ${total:0.00}");
}

Expected Output:
StudentLoan: $1120.00  
BusinessOwnerLoan: $1300.00  
RetireeLoan: $1180.00
*/

interface ILoan
{
    decimal CalculateFinalValue(decimal amount, int months);
}

class StudentLoan : ILoan
{
    public decimal CalculateFinalValue(decimal amount, int months)
    {
        decimal rate = 0.01m; // 1% per month
        return amount + (amount * rate * months);
    }
}

class BusinessOwnerLoan : ILoan
{
    public decimal CalculateFinalValue(decimal amount, int months)
    {
        decimal rate = 0.025m; // 2.5% per month
        return amount + (amount * rate * months);
    }
}

class RetireeLoan : ILoan
{
    public decimal CalculateFinalValue(decimal amount, int months)
    {
        decimal rate = 0.015m; // 1.5% per month
        return amount + (amount * rate * months);
    }
}

class Program
{
    static void Main()
    {
        List<ILoan> profiles = new List<ILoan>
        {
            new StudentLoan(),
            new BusinessOwnerLoan(),
            new RetireeLoan()
        };
        foreach (var profile in profiles)
        {
            decimal total = profile.CalculateFinalValue(1000m, 12);
            Console.WriteLine($"{profile.GetType().Name}: ${total:0.00}");
        }
    }
}