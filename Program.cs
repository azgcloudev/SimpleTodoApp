using SimpleTodoApp;

Console.WriteLine("Todo app, to get the instructions pass the command 'help'");
string? input = "";

do
{
    // Ask user to provide a command
    Console.Write("Enter command: ");
    input = Console.ReadLine();

    switch (input!.ToLower())
    {
        case "help":
            Help help = new Help();
            help.DisplayMenu();
            break;
        default:
            Console.WriteLine("Incorrect argument. Pass help if you need assistance.");
            break;
    }

} while (input != "exit");

Console.WriteLine("Good Bye!");

Console.Read();