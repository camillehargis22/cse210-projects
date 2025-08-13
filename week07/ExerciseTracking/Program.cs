using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activites = new List<Activity>();

        RunningActivity running = new RunningActivity("03 Nov 2022", 30, 3);
        activites.Add(running);

        CyclingActivity cycling = new CyclingActivity("04 Nov 2022", 30, 10);
        activites.Add(cycling);

        SwimmingActivity swimming = new SwimmingActivity("05 Nov 2022", 60, 50);
        activites.Add(swimming);

        foreach (Activity activity in activites)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}