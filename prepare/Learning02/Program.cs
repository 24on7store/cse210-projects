using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine("");
        {
            Job job1 = new Job();
            job1._jobTitle = "Software Development";
            job1._company = "Microsoft";
            job1._startYear = 2020;
            job1._endYear = 2022;

            Job job2 = new Job();
            job2._jobTitle = "Graphic Designer";
            job2._company = "THE BEES";
            job2._startYear = 2022;
            job2._endYear = 2023;

            Resume myResume = new Resume();
            myResume._name = "Mackison Jean Pierre";

            myResume._jobs.Add(job1);
            myResume._jobs.Add(job2);

            myResume.Display();
        }
        Console.Beep();
        Console.WriteLine();
    }
}