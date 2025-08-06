using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    // attributes
    private double _side;

    // constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * 2;
    }
}