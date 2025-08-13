// Base Activity class
public class Activity
{
    // attributes
    private string _date;
    private double _length;

    // constructor
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    // getters and setters
    public double GetLength()
    {
        return _length;
    }

    // virtual methods
    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return _date;
    }
}