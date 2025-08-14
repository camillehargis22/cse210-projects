// Checklist Goal class inherits Goal class
public class ChecklistGoal : Goal
{
    // attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // constructors
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    // getters and setters
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    // override methods
    public override void RecordEvent()
    {
        SetAmountCompleted(_amountCompleted + 1);
        int points = int.Parse(GetPoints()) + GetBonus();
        Console.WriteLine($"\nCongratulations! You have earned {points} points!");
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if (this.IsComplete())
        {
            return $"[X] {base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}~|~{_amountCompleted}~|~{_target}~|~{_bonus}";
    }

    public override int GetBonus()
    {
        if (this.IsComplete())
        {
            return _bonus;
        }
        else
        {
            return 0;
        }
    }
}