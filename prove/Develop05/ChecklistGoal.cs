using System.Formats.Tar;

public class ChecklistGoal : Goal
{
    

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;

    }


    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted ++; 

        if (!IsComplete())
        {
            Console.WriteLine($"\nCongratulations! You have earned {_points} points\n");
        
            _points = $"{int.Parse(_points)}";
            
            Console.WriteLine("Keep Going!");
        }
        else
        {
            _points = $"{int.Parse(_points) + _bonus}";
            Console.WriteLine($"\nCongratulations! You have earned {_points} points\n");
        }
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

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public override string GetDetailsString()
    {
        if (!IsComplete())
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }


}