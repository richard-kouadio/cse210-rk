using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _answers;


    public ListingActivity()
        : base(
        "Listing Activity",
        "This activity helps you reflect on positive things in your life."
        )
    {

        _prompts = new List<string>
        {
            "Who are people you appreciate?",
            "What are your personal strengths?",
            "Who helped you this week?"
        };


        _answers = new List<string>();

    }


    public void Run()
    {
        DisplayStartingMessage();


        Console.WriteLine();

        Console.WriteLine(
            _prompts[new Random().Next(_prompts.Count)]
        );


        Console.WriteLine(
            "Start listing items:"
        );


        DateTime end =
            DateTime.Now.AddSeconds(GetDuration());


        while(DateTime.Now < end)
        {
            Console.Write("> ");

            string answer = Console.ReadLine();

            if(answer != "")
            {
                _answers.Add(answer);
            }
        }


        Console.WriteLine(
            $"You listed {_answers.Count} items."
        );


        DisplayEndingMessage();
    }
}