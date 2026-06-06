using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;


    public ReflectingActivity()
        : base(
        "Reflecting Activity",
        "This activity helps you reflect on moments of strength and resilience."
        )
    {

        _prompts = new List<string>
        {
            "Think of a time when you helped someone.",
            "Think of a time when you did something difficult.",
            "Think of a time when you showed courage."
        };


        _questions = new List<string>
        {
            "Why was this experience meaningful?",
            "How did you feel when it was complete?",
            "What did you learn about yourself?",
            "How can you use this in the future?"
        };

    }


    public void Run()
    {
        DisplayStartingMessage();


        Console.WriteLine();
        Console.WriteLine(
            _prompts[new Random().Next(_prompts.Count)]
        );


        DateTime end =
            DateTime.Now.AddSeconds(GetDuration());


        while(DateTime.Now < end)
        {
            Console.WriteLine();

            Console.WriteLine(
                _questions[new Random().Next(_questions.Count)]
            );

            ShowSpinner(5);
        }


        DisplayEndingMessage();
    }
}