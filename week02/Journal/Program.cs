using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        const string PROMPTS_FILE = "prompts.txt";

        // load prompts
        PromptGenerator prompt = new PromptGenerator();
        prompt.LoadPrompts(PROMPTS_FILE);

        string input = "";
        Journal journal = new Journal();

        do {
            // show menu
            Console.WriteLine("Enter what you want to do from the choices below");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    // new entry
                    Entry entry = new Entry();

                    // get date
                    string date = DateTime.Now.ToShortDateString();

                    // get prompt
                    string promptText = prompt.GetRandomPrompt();

                    // show prompt
                    Console.WriteLine($"Todays Prompt: {promptText}");

                    // get entry
                    Console.WriteLine("Entry: ");
                    string line = Console.ReadLine();

                    entry._date = date;
                    entry._prompt = promptText;
                    entry._entry = line;

                    journal._entries.Add(entry);

                    break;

                case "2":
                    // Display the journal
                    journal.DisplayAll();

                    break;

                case "3":
                    // Load the journal from file of user's choice
                    Console.WriteLine("Enter file to load: ");
                    string fileToLoad = Console.ReadLine();
                    journal.LoadFromFile(fileToLoad);

                    break;

                case "4":
                    // Save the journal to file of user's choice
                    Console.WriteLine("Enter file to save journal: ");
                    string fileToSave = Console.ReadLine();
                    journal.SaveToFile(fileToSave);

                    break;
                default:
                    Console.WriteLine("Please enter a number 1 - 5");
                    break;
            }
        } while(input != "5");  
    }
}