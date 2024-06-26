
using System;
using System.Collections.Generic;
using System.IO;

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
}

class Program
{
    static List<JournalEntry> journal = new List<JournalEntry>();

    static void Main(string[] args)
    {
        bool exit = false;
        Console.WriteLine("");
        while (!exit)
        {
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    WriteNewEntry();
                    break;
                case 2:
                    DisplayJournal();
                    break;
                case 3:
                    SaveJournalToFile();
                    break;
                case 4:
                    LoadJournalFromFile();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void WriteNewEntry()
    {
        Console.WriteLine("Select a prompt:");
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        for (int i = 0; i < prompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }

        Console.Write("Enter the number of the prompt: ");
        int promptIndex = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Enter your response: ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry
        {
            Prompt = prompts[promptIndex],
            Response = response,
            Date = DateTime.Now
        };

        journal.Add(entry);
    }

    static void DisplayJournal()
    {
        foreach (var entry in journal)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    static void SaveJournalToFile()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in journal)
            {
                writer.WriteLine($"{entry.Date}\t{entry.Prompt}\t{entry.Response}");
            }
        }

        Console.WriteLine("Journal saved to the file.");
    }

    static void LoadJournalFromFile()
    {
        Console.Write("Enter the filename to load the journal from: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            journal.Clear(); // Clear the current journal entries.

            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split('\t');
                    if (parts.Length == 3)
                    {
                        DateTime date = DateTime.Parse(parts[0]);
                        string prompt = parts[1];
                        string response = parts[2];
                        journal.Add(new JournalEntry { Date = date, Prompt = prompt, Response = response });
                    }
                }
            }

            Console.WriteLine("Journal loaded from the file.");
        }
        else
        {
            Console.WriteLine("File not found.");
            Console.Beep();
            Console.WriteLine("");

        }
    }
}


