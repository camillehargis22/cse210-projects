// SwimmingActivity class inherits Activity
public class SwimmingActivity : Activity
{
    // attributes
    private double _laps;

    // constructor
    public SwimmingActivity(string date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    // override methods
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return this.GetDistance() / GetLength() * 60;
    }

    public override double GetPace()
    {
        return GetLength() / this.GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming ({GetLength()}) - Distance: {this.GetDistance()} miles, Speed: {this.GetSpeed()} mph, Pace: {this.GetPace()} min per mile";
    }
}