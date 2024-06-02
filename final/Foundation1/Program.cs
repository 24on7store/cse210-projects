using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation1 World!");
//     }
// }

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Console.WriteLine();
        Video video1 = new Video("How to learn English", "Johnsley Mejustin", 600);
        Video video2 = new Video("Cooking Pasta", "Emilie Ladouceur", 360);
        Video video3 = new Video("Travel Vlog - to the Caribbean", "Reims Forest", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Evens", "Great tutorial!"));
        video1.AddComment(new Comment("Barnabas", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Shenikah", "I learned a lot."));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "Yummy recipe!"));
        video2.AddComment(new Comment("Edna", "I will try this tonight."));
        video2.AddComment(new Comment("Phanel", "Looks delicious!"));

        // Add comments to video3
        video3.AddComment(new Comment("Mike", "Amazing footage!"));
        video3.AddComment(new Comment("Many", "Japan is beautiful."));
        video3.AddComment(new Comment("Yusuf", "Can't wait to visit!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
            Console.Beep();
        }
    }
}
