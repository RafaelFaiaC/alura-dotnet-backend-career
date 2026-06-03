/*Encapsulating Salary Adjustment

Imagine you are developing a payroll system. The "Employee" class has a salary that can only be increased via a method, and the new value cannot be lower than the current one. You want to ensure that this rule is not bypassed.

Create a class called "Employee" with:
- A public property "Name".
- A private field "salary".
- A constructor that receives the name and initial salary.
- A public method "AdjustSalary(double newValue)" that only accepts values greater than the current salary.
- A public read-only property "Salary" (get only).

Example Input:
Employee emp = new Employee("Fernanda Lima", 4000);
emp.AdjustSalary(3500); // Invalid
emp.AdjustSalary(4200); // Valid

Expected Output:
Error: The new salary must be greater than the current one.
Employee: Fernanda Lima
Current salary: $ 4,200.00
*/

class Employee
{
    public string Name { get; }
    private double salary;
    public Employee(string name, double initialSalary)
    {
        Name = name;
        salary = initialSalary;
    }
    public void AdjustSalary(double newValue)
    {
        if (newValue > salary)
        {
            salary = newValue;
        }
        else
        {
            Console.WriteLine("Error: The new salary must be greater than the current one.");
        }
    }
    public double Salary => salary;
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("Fernanda Lima", 4000);
        emp.AdjustSalary(3500); // Invalid
        emp.AdjustSalary(4200); // Valid

        Console.WriteLine($"Employee: {emp.Name}");
        Console.WriteLine($"Current salary: $ {emp.Salary:F2}");
    }
}