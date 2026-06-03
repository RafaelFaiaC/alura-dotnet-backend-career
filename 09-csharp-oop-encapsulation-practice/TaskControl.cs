/*Task Control using Encapsulation

You are developing a project management system. Each project has an internal list of tasks, which cannot be accessed or modified directly from outside the class. The system only allows adding tasks and needs to show how many already exist.

Create a class called "Project" with:
- A public property "Name".
- A private list of strings called "tasks".
- A public method "AddTask(string task)" that inserts a new task.
- A public method "DisplayTasks()" that prints all tasks.
- A read-only property "TaskCount" based on the list size.

Example Input:
Project project = new Project("Inventory System");
project.AddTask("Create login screen");
project.AddTask("Implement database");
project.DisplayTasks();

Expected Output:
Project: Inventory System
Tasks:
- Create login screen
- Implement database
Total: 2 tasks
*/

class Project
{
    public string Name { get; }
    private List<string> tasks;
    public Project(string name)
    {
        Name = name;
        tasks = new List<string>();
    }
    public void AddTask(string task)
    {
        tasks.Add(task);
    }
    public void DisplayTasks()
    {
        Console.WriteLine($"Project: {Name}");
        Console.WriteLine("Tasks:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"- {task}");
        }
        Console.WriteLine($"Total: {TaskCount} tasks");
    }
    public int TaskCount => tasks.Count;
}

class Program
{
    static void Main(string[] args)
    {
        Project project = new Project("Inventory System");
        project.AddTask("Create login screen");
        project.AddTask("Implement database");
        project.DisplayTasks();
    }
}