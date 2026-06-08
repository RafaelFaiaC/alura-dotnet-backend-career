/*Button Actions in Graphical User Interface using Interfaces and Polymorphism

Imagine you are developing the backend of an administrative panel with several buttons. Each button performs a specific action, such as saving, editing, or deleting data. You want to allow each action to have its own logic.

Your mission is to:
- Create the interface "IButtonAction" with the method "Execute()".
- Create the classes "SaveAction", "EditAction", and "DeleteAction" that implement this interface.
- Create a list of actions and execute them in a foreach loop.

Example Input:
List<IButtonAction> actions = new List<IButtonAction>
{
    new SaveAction(),
    new EditAction(),
    new DeleteAction()
};

foreach (var action in actions)
{
    action.Execute();
}

Expected Output:
Saving data to the database...  
Editing registration information...  
Deleting record from the system...
*/

interface IButtonAction
{
    void Execute();
}

class SaveAction : IButtonAction
{
    public void Execute()
    {
        Console.WriteLine("Saving data to the database...");
    }
}

class EditAction : IButtonAction
{
    public void Execute()
    {
        Console.WriteLine("Editing registration information...");
    }
}

class DeleteAction : IButtonAction
{
    public void Execute()
    {
        Console.WriteLine("Deleting record from the system...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IButtonAction> actions = new List<IButtonAction>
        {
            new SaveAction(),
            new EditAction(),
            new DeleteAction()
        };
        foreach (var action in actions)
        {
            action.Execute();
        }
    }
}