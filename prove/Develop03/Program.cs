using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine();

        
        var scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whosoever believeth in him should not perish, but have everlasting life.."
        );

        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
        string userInput;

        do
        {
            userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
            {
                Console.WriteLine("Goodbye!");
                Console.WriteLine();
                Console.Beep();
                break;
            }
            else
            {
                scripture.HideRandomWords();
                Console.WriteLine(scripture);
                Console.Beep();
            }
        } while (!scripture.AllWordsHidden);
    }
}

class Scripture
{
    private string reference;
    private List<ScriptureWord> words;
    private Random random = new Random();

    public bool AllWordsHidden => words.All(w => w.Hidden);

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new ScriptureWord(word)).ToList();
    }

    public void HideRandomWords()
    {
        int wordsToHide = random.Next(1, words.Count);
        var wordsToHideIndices = Enumerable.Range(0, words.Count).OrderBy(x => random.Next()).Take(wordsToHide);

        foreach (var index in wordsToHideIndices)
        {
            words[index].Hide();
        }
    }

    public override string ToString()
    {
        return $"{reference}: {string.Join(" ", words)}";
    }
}

class ScriptureReference
{
    private string reference;

    public ScriptureReference(string reference)
    {
        this.reference = reference;
    }

    public override string ToString()
    {
        return reference;
    }
}

class ScriptureWord
{
    private string word;
    public bool Hidden { get; private set; }

    public ScriptureWord(string word)
    {
        this.word = word;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public override string ToString()
    {
        return Hidden ? new string('*', word.Length) : word;
    }
}

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop03 World!");
        
//     }
// }