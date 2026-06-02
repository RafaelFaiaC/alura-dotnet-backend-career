/*Employee Registration with Inheritance

You are developing an employee management system for a company that wants to organize its employees' information. The company has full-time employees, who receive a monthly salary, and freelancers, who work on projects with specific values. Your challenge is to create a structure that represents these two types of collaborators, leveraging inheritance concepts to avoid code repetition.

Create a program that:
- Defines a base class "Employee" with the attributes "Name" and "Position".
- Creates a child class "Freelancer" that inherits from "Employee" and adds the attribute "ProjectValue".
- Creates a child class "FullTimeEmployee" that inherits from "Employee" and adds the attribute "Salary".
- Instantiates at least one object of each child class, assigning values to each attribute.
- Displays the information in the terminal.

Example Input:
FullTimeEmployee emp1 = new FullTimeEmployee("Luciana", "Developer", 7000.00m);  
Freelancer emp2 = new Freelancer("Carlos", "Designer", 3500.00m);  

Expected Output:
Employee Luciana – Position: Developer – Salary: $ 7,000.00
Freelancer Carlos – Position: Designer – Current Project: $ 3,500.00
*/

class Employee
{
    public string Name { get; }
    public string Position { get; }
    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }
}

class Freelancer : Employee
{
    public decimal ProjectValue { get; }
    public Freelancer(string name, string position, decimal projectValue) : base(name, position)
    {
        ProjectValue = projectValue;
    }
}

class FullTimeEmployee : Employee
{
    public decimal Salary { get; }
    public FullTimeEmployee(string name, string position, decimal salary) : base(name, position)
    {
        Salary = salary;
    }
}

class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee emp1 = new FullTimeEmployee("Luciana", "Developer", 7000.00m);
        Freelancer emp2 = new Freelancer("Carlos", "Designer", 3500.00m);

        Console.WriteLine($"Employee {emp1.Name} – Position: {emp1.Position} – Salary: $ {emp1.Salary:N2}");
        Console.WriteLine($"Freelancer {emp2.Name} – Position: {emp2.Position} – Current Project: $ {emp2.ProjectValue:N2}");
    }
}