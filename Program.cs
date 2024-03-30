using SimpleTodoApp;

Console.WriteLine("Todo app, to get the instructions pass the command 'help'");
string? input = "";

do
{
    // Ask user to provide a command
    Console.Write("Enter command: ");
    input = Console.ReadLine();

    Todo todo = new Todo();

    switch (input!.ToLower())
    {
        case "exit":
            break;
        case "add":
            AddCommand(todo);
            break;
        case "help":
            HelpCommand();
            break;
        default:
            Console.WriteLine("Incorrect argument. Pass help if you need assistance.");
            break;
    }

} while (input.ToLower() != "exit");

Console.WriteLine("Good Bye!");

Console.Read();

/// <summary>
/// This functions runs when the user select help as command.
/// </summary>
void HelpCommand()
{
    Help help = new Help();
    help.DisplayMenu();
}

void AddCommand(Todo todo)
{
    todo.AddItem();
}