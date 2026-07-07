using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Bake Cookies", "Sarah", 420);
        video1.AddComment(new Comment("Mike", "Great recipe!"));
        video1.AddComment(new Comment("Emma", "I made these today."));
        video1.AddComment(new Comment("Chris", "Thanks for sharing."));
        videos.Add(video1);

        Video video2 = new Video("Gaming Highlights", "Jake", 615);
        video2.AddComment(new Comment("Ryan", "That ending was awesome."));
        video2.AddComment(new Comment("Olivia", "Nice gameplay."));
        video2.AddComment(new Comment("Noah", "Can't wait for more."));
        videos.Add(video2);

        Video video3 = new Video("Top 10 Travel Spots", "Emily", 780);
        video3.AddComment(new Comment("Sophia", "I want to visit these."));
        video3.AddComment(new Comment("Liam", "Beautiful places."));
        video3.AddComment(new Comment("Ava", "Very helpful video."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            Console.WriteLine();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}