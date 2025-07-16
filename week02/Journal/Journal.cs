// Class Journal
public class Journal
{
    // const variable of indexes
    const int DATE_INDEX = 0;
    const int PROMPT_INDEX = 1;
    const int ENTRY_INDEX = 2;

    // attributes
    public List<Entry> _entries = new List<Entry>();

    // Constructor
    public Journal()
    {

    }

    // Method to add a Journal Entry
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Method to display all Journal Entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Method to save Journal Entries to the named file
    public void SaveToFile(string file)
    {
        // clear text file
        File.WriteAllText(file, "");

        // add all entries to text
        using (StreamWriter outputFile = File.AppendText(file))
        {
            // add each entry to file
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.SaveEntry());
            }
        }
    }

    // Method to load Journal Entries from the named file
    public void LoadFromFile(string file)
    {
        // make sure all entries are saved before loading file
        // Clear out _entries to be able to pull fresh journal entries
        if (_entries.Count > 0)
        {
            // ask if want to save work first
            Console.Write("Would you like to save first? (y or n)");
            string input = Console.ReadLine();
            if (input == "y")
            {
                // Save the journal to file of user's choice
                Console.WriteLine("Enter file to save journal: ");
                string fileToSave = Console.ReadLine();
                SaveToFile(fileToSave);
            }

            // clear _entries
            _entries.Clear();
        }

        // create array of strings from file
        string[] lines = System.IO.File.ReadAllLines(file);

        // for each line, create new Entry and save to _entries list
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            Entry entry = new Entry();
            entry._date = parts[DATE_INDEX];
            entry._prompt = parts[PROMPT_INDEX];
            entry._entry = parts[ENTRY_INDEX];

            _entries.Add(entry);
        }
    }
}