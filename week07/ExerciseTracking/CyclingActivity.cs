// CyclingActivity class inherits Activity
public class CyclingActivity : Activity
{
    // attributes
    private double _speed;

    // constructor
    public CyclingActivity(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    // override methods
    public override double GetDistance()
    {
        return _speed / 60 * GetLength();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return GetLength() / this.GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling ({GetLength()} min) - Distance: {this.GetDistance()} miles, Speed: {this.GetSpeed()} mph, Pace: {this.GetPace()} min per mile";
    }
}