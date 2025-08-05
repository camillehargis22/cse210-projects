// Breathing Activity class
// inherits Activity
public class BreathingActivity : Activity
{
    // constructor
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    // methods
    public void Run()
    {
        // standard starting message
        DisplayStartingMessage();

        Breathe();

        // standard ending message
        DisplayEndingMessage();
    }

    private void Breathe()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in... ");
            ShowCountDown(3);

            Console.WriteLine("Breath out... ");
            ShowCountDown(5);
        }
    }
}