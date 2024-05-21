// Program.cs
using System;
using MindfulnessProgram.Activities;

class Program
{
    static void Main(string[] args)
    // Console.Write();
    {
        while (true)
        {  
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            
            Console.Write("Select an activity: ");
            // Console.Write();
            string choice = Console.ReadLine();
        
        

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    ShowSpinner(2);
                    continue;
            }

        

            activity.Start();
        }
    }

    private static void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine();
        
    }
}



// using System;

// class Program
// {
//     static void Main(string[] args)
//     {   Console.WriteLine();
//         Console.WriteLine("Hello Develop04 World!");


//         Console.WriteLine();
//         Console.Beep();
//     }
// }