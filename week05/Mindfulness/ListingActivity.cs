// Listing Activity class
// inherits Activity
public class ListingActivity : Activity
{
    // attributes
    private List<string> _prompts;

    // constructor
    public ListingActivity(string name, string description, int duration, List<string> prompts) : base(name, description, duration)
    {
        _prompts = prompts;
    }

    // methods
    public void Run()
    {
        // standard starting message
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");

        // display random prompt, give several seconds to think about
        GetRandomPrompt();

        Console.WriteLine("You may begin in: ");
        ShowCountDown(10);

        // prompt to list items for duration
        List<string> items = GetListFromUser();

        // display number of items
        Console.WriteLine($"You listed {items.Count} items!");

        // standard ending message
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        Console.WriteLine($"--- {_prompts[randomIndex]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            items.Add(item);
        }

        return items;
    }
}