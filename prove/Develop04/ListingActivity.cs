
using System;
using System.Collections.Generic;

namespace MindfulnessProgram.Activities
{
    public class ListingActivity : Activity
    {
        private List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() 
            : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        protected override void ExecuteActivity()
        {
            Random rand = new Random();
            string prompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine(prompt);
            Console.WriteLine("You have a few seconds to start thinking about the prompt...");
            ShowCountdown(5);

            List<string> items = new List<string>();
            Console.WriteLine("Start listing items:");

            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    items.Add(item);
                }
            }

            Console.WriteLine($"You listed {items.Count} items:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
