// Entry class
public class Entry
{
    // attributes
    public string _date = "";
    public string _prompt = "";
    public string _entry = "";

    // Constructor
    public Entry()
    {

    }

    // Method to display the Entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
        Console.WriteLine("");
    }

    // Method to save Entry to file
    public string SaveEntry()
    {
        return $"{_date}~|~{_prompt}~|~{_entry}";
    }
}