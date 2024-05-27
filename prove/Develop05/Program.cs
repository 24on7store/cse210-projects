using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalM;
        Console.Write("What is your Name?" );
        string name = Console.ReadLine();
        Console.WriteLine();
        
        
        bool exit = true;
        goalM = new GoalManager(name); 

        while (exit)
        {
            goalM.Start();

            string actionFromUser = Console.ReadLine();

            switch (actionFromUser)
            {
                case "1":
                    goalM.CreateGoal();
                    Console.WriteLine();
                    break;

                case "2":
                    goalM.ListGoalDetails();
                    Console.WriteLine();
                    goalM.DisplayPlayerInfo();
                    break;

                case "3":
                    goalM.SaveGoals();
                    break;

                case "4":
                    goalM.LoadGoals();
                    break;

                case "5":
                    goalM.RecordEvent();
                    break;

                case "6":
                    exit = false;
                    break;
            }

        }

        
    }
}