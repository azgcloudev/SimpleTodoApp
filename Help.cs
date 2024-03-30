namespace SimpleTodoApp;

public class Help
{
    // Empty constructor
    public Help() { }

    /// <summary>
    /// Displays the command options in the application as a menu format.
    /// </summary>
    public void DisplayMenu()
    {
        Console.WriteLine("\n******** Commands **********");
        Console.WriteLine("add:     Adds a new list to the todo.");
        Console.WriteLine("list:    Shows all the todo's.");
        Console.WriteLine("remove:  Remove an entry in the list.");
        Console.WriteLine("exit:    Exit from the application.");

        Console.WriteLine();
    }
}
