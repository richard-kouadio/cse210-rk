using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _random = new Random();

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity helps you list positive things in your life."
        )
    {
        _prompts = new List<string>
        {
            "List people you appreciate:",
            "List your personal strengths:",
            "List things you are grateful for:",
            "List people who helped you recently:"
        };
    }

    protected override void PerformActivity()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine("\n" + prompt);

        ShowCountdown(5);

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        int count = 0;

        Console.WriteLine("\nStart listing items:");

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                count++;
            }
        }

        Console.WriteLine($"\nYou listed {count} items!");
    }
}