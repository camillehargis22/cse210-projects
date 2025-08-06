public class HourlyEmployee : Employee
{
    private float _payRate = 0;
    private int _hours = 0;

    public float GetPayRate()
    {
        return _payRate;
    }

    public void SetPayRate(float payrate)
    {
        _payRate = payrate;
    }

    public int GetHours()
    {
        return _hours;
    }

    public void SetHours(int hours)
    {
        _hours = hours;
    }

    public override float GetPay()
    {
        return _hours * _payRate;
    }
}