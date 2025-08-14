using System.IO;

// Goal Manager class
public class GoalManager()
{
    // attributes
    private List<Goal> _goals;
    private int _score;

    public void SetScore(int score)
    {
        _score = score;
    }

    // methods
    public void Start()
    {
        _goals = new List<Goal>();
        int choice = 0;
        while (choice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"  {count}. {goal.GetShortName()}");
            count++;
        }
    }

    public void ListGoalDetails()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"  {count}. {goal.GetDetailsString()}");
            count++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        if (choice == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (choice == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (choice == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.WriteLine("What goal did you accomplish? ");
        int goalAccomplished = int.Parse(Console.ReadLine()) -1;

        _goals[goalAccomplished].RecordEvent();

        int points = int.Parse(_goals[goalAccomplished].GetPoints()) + _goals[goalAccomplished].GetBonus();

        SetScore(_score + points);
        Console.WriteLine($"You now have {_score} points.\n");
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        SetScore(int.Parse(lines[0]));
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            string name = parts[0];
            string description = parts[1];
            string points = parts[2];

            if (parts.Length == 3)
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if (parts.Length == 4)
            {
                bool isComplete = bool.Parse(parts[3]);
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(simpleGoal);
            }
            else if (parts.Length == 6)
            {
                int amountCompleted = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
                _goals.Add(checklistGoal);
            }
        }
    }
}