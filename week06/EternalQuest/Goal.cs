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

    // getters and setters
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetPoints()
    {
        return _points;
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
        return $"{_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}~|~{_description}~|~{_points}";
    }

    public virtual int GetBonus()
    {
        return 0;
    }
}