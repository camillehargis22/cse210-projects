// Eternal Goal class inherits Goal class
public class EternalGoal : Goal
{
    // constructor
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    // override methods
    public override void RecordEvent()
    {
        Console.WriteLine($"\nCongratulations! You have earned {GetPoints()} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {base.GetDetailsString()}";
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}