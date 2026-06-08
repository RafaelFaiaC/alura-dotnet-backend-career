/*Employee Report using Method Overriding

Imagine you are building an HR system that generates personalized reports. You created a base class called "Employee", and two subclasses: "Manager" and "Developer". Each type of employee must generate a different report, overriding a method called "GenerateReport()".

Create these three classes with a public virtual string "GenerateReport()" method in the base class, and override this method in the child classes.

Example Input:
Employee f1 = new Manager();
Employee f2 = new Developer();

Console.WriteLine(f1.GenerateReport());
Console.WriteLine(f2.GenerateReport());

Expected Output:
Manager report: supervises the team.
Developer report: writes code and fixes bugs.
*/

class Employee
{
    public virtual string GenerateReport()
    {
        return "Employee report: general information.";
    }
}

class Manager : Employee
{
    public override string GenerateReport()
    {
        return "Manager report: supervises the team.";
    }
}

class Developer : Employee
{
    public override string GenerateReport()
    {
        return "Developer report: writes code and fixes bugs.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee f1 = new Manager();
        Employee f2 = new Developer();

        Console.WriteLine(f1.GenerateReport());
        Console.WriteLine(f2.GenerateReport());
    }
}