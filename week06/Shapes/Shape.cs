public class Shape
{
    // attributes
    private string _color;

    // constructor
    public Shape(string color)
    {
        _color = color;
    }

    // getters and setters
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // virtual methods
    public virtual double GetArea()
    {
        return 0;
    }
}