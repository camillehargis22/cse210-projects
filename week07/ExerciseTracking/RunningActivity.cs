// RunningActivity class inherits Activity
public class RunningActivity : Activity
{
    // attributes
    private double _distance;

    // constructor
    public RunningActivity(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    // override methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetLength() * 60;
    }

    public override double GetPace()
    {
        return GetLength() / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running ({GetLength()} min) - Distance: {this.GetDistance()} miles, Speed: {this.GetSpeed()} mph, Pace: {this.GetPace()} min per mile";
    }
}