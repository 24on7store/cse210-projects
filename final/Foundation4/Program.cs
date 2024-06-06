using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        
        List<Activity> _activities = new List<Activity>()
        {

            new Running("Number two", "- July 15, 2024", 60, 5.5),
            
            new StationaryBicycles("Number 4", "- August 27, 2024", 40, 2),

            new Swimming("- September 4, 2024", 30, 20)
        };

        foreach (Activity i in _activities)
        {
            Console.WriteLine(i.GetSummary());
        }

        Console.WriteLine();
        Console.Beep();
    }
}