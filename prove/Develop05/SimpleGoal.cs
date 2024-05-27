public class SimpleGoal : Goal
{
    //Attributes
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points, bool status) : base(name, description, points)
    {

        _isComplete = status;

    } //By the base constructor we are going to obtain the
    //names, descriptions and points.


    //Methods
    public override void RecordEvent()
    {
        Console.WriteLine($"\nCongratulations! You have earned {_points} points\n");
        _isComplete = true;
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string text = $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
        return text;
    }

}