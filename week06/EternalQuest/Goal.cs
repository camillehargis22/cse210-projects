// Goal class
using System.ComponentModel;

public class Goal
{
    // attributes
    private string _shortName;
    private string _description;
    private string _points;

    // constructor
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // virtual methods
    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return "text";
    }

    public virtual string GetStringRepresentation()
    {
        return "text";
    }
}