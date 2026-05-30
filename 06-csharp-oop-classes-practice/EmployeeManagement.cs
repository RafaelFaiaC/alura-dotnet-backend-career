/*Employee Management

You are developing a personnel management system for a company. The system needs to register employees by providing their name and position at the time of creation. Also, it must allow an employee to be promoted to a new position, but only if the new position is different from the current one — it wouldn't make sense to have a promotion that doesn't change the person's position, right?!

Create a class called "Employee" that has:
- A public property "Name".
- A public property "Position".
- A constructor that receives name and position as required parameters.
- A method called "Promote(string newPosition)" that updates the employee's position, only if the new position is different from the current one. If it is the same, display an error message stating that the promotion cannot occur.

Then, create an instance of the class, display the initial data, promote the employee, and display the updated data.

Example Input:
Employee employee = new Employee("Carlos Pereira", "Administrative Assistant");
employee.Promote("Administrative Assistant"); // Invalid attempt
employee.Promote("Project Analyst");          // Valid promotion

Expected Output:
Employee: Carlos Pereira
Current Position: Administrative Assistant
Error: The new position must be different from the current position.
 
Promotion carried out successfully!
 
--- After promotion ---
Employee: Carlos Pereira
Current Position: Project Analyst
*/

class Employee
{
    public string Name { get; }
    public string Position { get; private set; }
    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }
    public void Promote(string newPosition)
    {
        if (newPosition == Position)
        {
            Console.WriteLine("Error: The new position must be different from the current position.");
        }
        else
        {
            Position = newPosition;
            Console.WriteLine("Promotion carried out successfully!");
        }
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("Carlos Pereira", "Administrative Assistant");
        Console.WriteLine($"Employee: {employee.Name}");
        Console.WriteLine($"Current Position: {employee.Position}");

        employee.Promote("Administrative Assistant"); // Invalid attempt
        employee.Promote("Project Analyst");          // Valid promotion

        Console.WriteLine("\n--- After promotion ---");
        Console.WriteLine($"Employee: {employee.Name}");
        Console.WriteLine($"Current Position: {employee.Position}");
    }
}