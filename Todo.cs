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
    public void AddItem(string text)
    {
        items.Add(text);
    }

    /// <summary>
    /// ListItems displays in the console all the items in the list with their index position in the list.
    /// </summary>
    public void ListItems()
    {
        Console.WriteLine("Index | Text");
        Console.WriteLine("____________");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i}     | {items[i]}");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// HowManyItems displays the total items in the todo list.
    /// </summary>
    public void HowManyItems()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("There are no items.");
            return;
        }

        if (items.Count == 1)
        {
            Console.WriteLine("There is only 1 item");
        }
        else
        {
            Console.WriteLine($"There are {items.Count} in the list");
        }
    }

    public void RemoveItem(string index)
    {
        bool isValidIndex = int.TryParse(index, out int i);

        if (isValidIndex)
        {
            try
            {
                items.RemoveAt(i);
                Console.WriteLine("Item removed\n");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"Index is out of range, the index {i} doesn't exists.");
                Console.WriteLine("Try again");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Index is not valid, try again with a valid index number.");
        }
    }

}
