// Reflecting Activity class
// inherits Activity
public class ReflectingActivity : Activity
{
    // attributes
    private List<string> _prompts;
    private List<string> _questions;

    // constructor
    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    // methods
    public void Run()
    {
        // standard starting message
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");

        // show random prompt
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.WriteLine("When you have something in mind, press enter to continue.");

        // do not move forward until user pushes enter
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine($"You may begin in: ");
        ShowCountDown(5);

        // show random questions, pausing with spinner between questions until duration ends
        DisplayQuestions();

        // standard ending message
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _questions.Count);
        return _questions[randomIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\nGetRandomQuestion()");
            for (int i = 10; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
        }
    }
}