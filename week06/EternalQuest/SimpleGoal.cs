// Simple Goal class inherits Goal class
public class SimpleGoal : Goal
{
    // attributes
    private bool _isComplete;

    // constructors
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // override methods
    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"\nCongratulations! You have earned {GetPoints()} points!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if (_isComplete)
        {
            return $"[X] {base.GetDetailsString()}";
        }
        else
        {
            return $"[ ] {base.GetDetailsString()}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}~|~{_isComplete}";
    }
}