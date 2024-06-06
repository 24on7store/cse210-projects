using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        //Main Program Project Number 4

        Lecture event1 = new Lecture("THE BEES ANNIVERSARY", "This event will have the purpose to celebrate 15th anniversary of the club", "15/06/2024", new TimeOnly(17, 0, 0), new Address("1 Jaelle", "Delmas 33", "Haiti", "Haiti"), "lecture", "Edgard", 35);

        Receptions event2 = new Receptions("sophoni@gelin.com", "Sophoni's Wedding", "Wedding of Sophoni and Yamiley", "26/06/2024", new TimeOnly(15, 30, 0), new Address("Boulevard Rue Benoit", "Leogane", "Florida", "United States"), "reception", true);

        Outdoor event3 = new Outdoor("Summer Championship", "Everyone who knows how to play football is invited to participate  in our 10 edition of this championship", "01/11/2024", new TimeOnly(8, 0, 0), new Address("1 Avenue Boulos", "Gressier", "Gressier", "Haiti"), "outdoor", "Sunny");

        Console.WriteLine("\n------------------------First Event------------------------\n");

        Console.WriteLine("-----------------Standard Details------------------------------");
        Console.WriteLine(event1.StandarDetails());
        Console.WriteLine('\n');
        Console.WriteLine("-----------------Short Description-----------------------------");
        Console.WriteLine(event1.ShortDescription());
        Console.WriteLine('\n');
        Console.WriteLine("-----------------Full Details--------------------------------");
        Console.WriteLine(event1.FullDetails(event1.GetMessage()));

        //Event 2
        Console.WriteLine("\n------------------------ Second Event-------------------------\n");
        Console.WriteLine("-----------------Standard Details--------------------------------");
        Console.WriteLine(event2.StandarDetails());
        Console.WriteLine('\n');
        Console.WriteLine("-----------------Short Description--------------------------------");
        Console.WriteLine(event2.ShortDescription());
        Console.WriteLine('\n');
        Console.WriteLine("-----------------Full Description--------------------------------");
        Console.WriteLine(event2.FullDetails(event2.GetMessage()));


        Console.WriteLine("\n------------------------Third Event---------------------------\n");
        Console.WriteLine("-----------------Standard Details--------------------------------");
        Console.WriteLine(event3.StandarDetails());
        Console.WriteLine("\n-----------------Short Description---------------------------\n");
        Console.WriteLine(event3.ShortDescription());
        Console.WriteLine('\n');
        Console.WriteLine("-----------------Full Description--------------------------------");

        Console.WriteLine(event3.FullDetails(event3.GetMessage()));

        Console.WriteLine();
        Console.Beep();

    }
}