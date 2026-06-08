/*Scheduled Task Execution using Abstract Classes and Polymorphism

You are creating a scheduled task system. The system must execute different types of tasks, such as performing a backup, sending reports, and cleaning temporary files. Each task needs to follow a common structure with a method called "Execute()".

Create an abstract class called "ScheduledTask" with an abstract method "Execute()". Then, create three classes that inherit from it: "BackupTask", "ReportTask", and "CleanupTask". Each one must override the "Execute" method with its own logic.

Finally, create a list of "ScheduledTask" with different types of tasks and iterate through this list, executing each one.

Example Input:
List<ScheduledTask> tasks = new List<ScheduledTask>
{
    new BackupTask(),
    new ReportTask(),
    new CleanupTask()
};

foreach (var task in tasks)
{
    task.Execute();
}

Expected Output:
Executing system backup task...
Generating and sending daily report...
Cleaning temporary files from the server...
*/

abstract class ScheduledTask
{
    public abstract void Execute();
}

class BackupTask : ScheduledTask
{
    public override void Execute()
    {
        Console.WriteLine("Executing system backup task...");
    }
}

class ReportTask : ScheduledTask
{
    public override void Execute()
    {
        Console.WriteLine("Generating and sending daily report...");
    }
}

class CleanupTask : ScheduledTask
{
    public override void Execute()
    {
        Console.WriteLine("Cleaning temporary files from the server...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<ScheduledTask> tasks = new List<ScheduledTask>
        {
            new BackupTask(),
            new ReportTask(),
            new CleanupTask()
        };
        foreach (var task in tasks)
        {
            task.Execute();
        }
    }
}