// Activity class
using System.Linq.Expressions;

public class Activity
{
    // attributes
    private string _name;
    private string _description;
    private int _duration;

    // constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // getters and setters
    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_description);

        Console.WriteLine("How long, in seconds, would you like for this session? ");
        SetDuration(int.Parse(Console.ReadLine()));

        Console.WriteLine("Get ready...");

        // show spinner
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!\n");

        // show spinner
        ShowSpinner(5);

        Console.Write($"You have now completed another {_duration} seconds of the {_name} Activity.");

        // show spinner
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            if (i > 999)
            {
                Console.Write("\b\b\b\b    \b\b\b\b");
            }
            else if (i > 99)
            {
                Console.Write("\b\b\b   \b\b\b");
            }
            else if (i > 9)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
        }
    }
}