namespace SimpleTodoApp;

public class Help
{
    // Empty constructor
    public Help() { }


    // Display menu
    public void DisplayMenu()
    {
        Console.WriteLine("\n******** Commands **********");
        Console.WriteLine("add: Adds a new list to the todo.");
        Console.WriteLine("list: Shows all the todo's.");

        Console.WriteLine();
    }
}
