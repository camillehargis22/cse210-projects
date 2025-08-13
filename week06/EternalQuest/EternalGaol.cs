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

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "text";
    }
}