using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a simple assignment
        Console.WriteLine();
        Assignment assignment1 = new Assignment("Mack Jean Pierre", "Division");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();


        //Create a simple math assignment
        MathAssignment assignment2 = new MathAssignment("Evens Jean", "Fraction", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine();



        WritingAssignment assignment3 = new WritingAssignment("Reims Forest", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());

        Console.WriteLine();
        Console.Beep();


    }
}