/*Service Management combining Interfaces and Composition

Imagine you are creating a system for a technology company that offers different types of services (such as maintenance or consulting). Each service has a technical person in charge (employee), and each type of service has its own way of executing the task.

The goal is to ensure that all services can be executed in a standardized way, but with specific logic. Also, each service must contain a responsible employee.

Your challenge is to combine interfaces and composition to represent this structure.

Create a program that:
- Defines the interface "IService" (or "IServico"), with the method "ExecuteService()".
- Creates the "Employee" class, with the attributes "Name" and "Department".
- Creates the "Maintenance" and "Consulting" classes, which implement "IService".
- In each class, associate an "Employee" through composition and implement the "ExecuteService()" method displaying:
  * The type of service
  * The task title
  * And the data of the responsible employee.
- In Program.cs, instantiate the services and call the "ExecuteService()" method.

Example Input:
Employee technician = new Employee("João", "IT");
IService s1 = new Maintenance("Server update", technician);

Employee analyst = new Employee("Marina", "Consulting");
IService s2 = new Consulting("Strategic planning", analyst);

s1.ExecuteService();
s2.ExecuteService();

Expected Output:
Executing maintenance service: Server update
Responsible: João - Department: IT
Executing consulting service: Strategic planning
Responsible: Marina - Department: Consulting
*/

interface IService
{
    void ExecuteService();
}

class Employee
{
    public string Name { get; }
    public string Department { get; }
    public Employee(string name, string department)
    {
        Name = name;
        Department = department;
    }
}

class Maintenance : IService
{
    private string TaskTitle { get; }
    private Employee Responsible { get; }
    public Maintenance(string taskTitle, Employee responsible)
    {
        TaskTitle = taskTitle;
        Responsible = responsible;
    }
    public void ExecuteService()
    {
        Console.WriteLine($"Executing maintenance service: {TaskTitle}");
        Console.WriteLine($"Responsible: {Responsible.Name} - Department: {Responsible.Department}");
    }
}

class Consulting : IService
{
    private string TaskTitle { get; }
    private Employee Responsible { get; }
    public Consulting(string taskTitle, Employee responsible)
    {
        TaskTitle = taskTitle;
        Responsible = responsible;
    }
    public void ExecuteService()
    {
        Console.WriteLine($"Executing consulting service: {TaskTitle}");
        Console.WriteLine($"Responsible: {Responsible.Name} - Department: {Responsible.Department}");
    }
}

class Program
{
    static void Main()
    {
        Employee technician = new Employee("João", "IT");
        IService s1 = new Maintenance("Server update", technician);

        Employee analyst = new Employee("Marina", "Consulting");
        IService s2 = new Consulting("Strategic planning", analyst);

        s1.ExecuteService();
        s2.ExecuteService();
    }
}