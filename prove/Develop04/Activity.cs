// Activities/Activity.cs
using System;
using System.Threading;

namespace MindfulnessProgram.Activities
{
    public abstract class Activity
    {
        protected string Name;
        protected string Description;
        protected int Duration;

        public Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Start()
        {
            Console.WriteLine($"Starting {Name} Activity");
            Console.WriteLine(Description);
            Console.Write("Enter the duration in seconds: ");
            Duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);

            ExecuteActivity();

            Console.WriteLine("Good job!");
            Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
            ShowSpinner(3);
        }

        protected abstract void ExecuteActivity();

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
