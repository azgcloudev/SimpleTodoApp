namespace SimpleTodoApp;

public class Todo
{

    // This list will hold all the items.
    List<string> items = new List<string> { };

    public Todo() { }

    /// <summary>
    /// AdddItem adds the text into the list.
    /// </summary>
    /// <param name="text">String of text.</param>
    public void AddItem()
    {   
        Console.Write("Enter text here: ");
        string? inputText = Console.ReadLine();
        items.Add(inputText);
    }
}
