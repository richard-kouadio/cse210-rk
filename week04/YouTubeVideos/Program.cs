using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(
            "Learn C# in 30 Minutes",
            "John Smith",
            1800);

        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing."));

        Video video2 = new Video(
            "Object-Oriented Programming Basics",
            "Jane Doe",
            2400);

        video2.AddComment(new Comment("Emma", "Excellent explanation."));
        video2.AddComment(new Comment("David", "Easy to understand."));
        video2.AddComment(new Comment("Sophia", "I learned a lot."));

        Video video3 = new Video(
            "C# Collections Explained",
            "Mike Johnson",
            1500);

        video3.AddComment(new Comment("Olivia", "Very informative."));
        video3.AddComment(new Comment("Liam", "Great examples."));
        video3.AddComment(new Comment("Noah", "Awesome video!"));

        Video video4 = new Video(
            "Programming Tips for Beginners",
            "Sarah Wilson",
            2100);

        video4.AddComment(new Comment("Ava", "Perfect for beginners."));
        video4.AddComment(new Comment("Lucas", "Thanks for the tips."));
        video4.AddComment(new Comment("Mia", "Looking forward to more videos."));

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine();

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}