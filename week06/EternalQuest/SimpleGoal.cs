// Simple Goal class inherits Goal class
public class SimpleGoal : Goal
{
    // attributes
    private bool _isComplete;

    // constructor
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // override methods
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "text";
    }
}