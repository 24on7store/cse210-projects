
using System;

namespace MindfulnessProgram.Activities
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() 
            : base("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        protected override void ExecuteActivity()
        {
            int interval = 5; // seconds for each breath in and out
            int cycles = Duration / (interval * 2);

            for (int i = 0; i < cycles; i++)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(interval);
                Console.WriteLine("Breathe out...");
                ShowCountdown(interval);
            }
        }
    }
}
