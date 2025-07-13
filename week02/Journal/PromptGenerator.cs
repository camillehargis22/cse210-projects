// import System.IO to read and write from file
using System.IO;

// Prompt Generator class
public class PromptGenerator
{
    // attributes
    public List<string> _prompts = new List<string>();

    // Constructor
    public PromptGenerator()
    {

    }

    // Method to get a random prompt from the list of _prompts
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptNumber = random.Next(0, _prompts.Count);
        return _prompts[promptNumber];
    }

    // Method to load prompts from file and add to list of _prompts
    public void LoadPrompts(string file)
    {
        string[] prompts = System.IO.File.ReadAllLines(file);

        foreach (string prompt in prompts)
        {
            _prompts.Add(prompt);
        }
    }

    // Method to save prompt to file (not currently in use, mostly used at beginning to add prompts manually)
    public void SavePrompt(string file, string prompt)
    {
        using (StreamWriter outputFile = File.AppendText(file))
        {
            // add prompt to file
            outputFile.WriteLine(prompt);
        }
    }
}