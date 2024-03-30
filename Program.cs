using SimpleTodoApp;

Console.WriteLine("Todo app, to get the instructions pass the command 'help'");

string input;

// Initialize the todo object
Todo todo = new Todo();

do
{
    // Ask user to provide a command
    Console.Write("Enter command: ");
    input = Console.ReadLine() ?? "";

    switch (input.ToLower())
    {
        case "exit":
            break;
        case "add":
            Console.Write("\nEnter the item text: ");
            string text = Console.ReadLine() ?? "";
            todo.AddItem(text);
            break;
        case "remove":
            Console.Write("Which index item you want to remove?: ");
            string idx = Console.ReadLine() ?? "-1";
            todo.RemoveItem(idx);
            break;
        case "list":
            todo.ListItems();
            break;
        case "count":
            todo.HowManyItems();
            break;
        case "help":
            Help help = new Help();
            help.DisplayMenu();
            break;
        default:
            Console.WriteLine("Incorrect argument. Pass help if you need assistance.");
            break;
    }

} while (input.ToLower() != "exit");

Console.WriteLine("Good Bye!");

//End of application