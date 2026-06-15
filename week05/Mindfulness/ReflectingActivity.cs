using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _availableQuestions;
    private Random _random = new Random();

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity helps you reflect on moments of strength."
        )
    {
        _prompts = new List<string>
        {
            "Think of a time you helped someone.",
            "Think of a time you overcame a challenge.",
            "Think of a time you showed courage."
        };

        _questions = new List<string>
        {
            "Why was this meaningful?",
            "How did you feel?",
            "What did you learn?",
            "How can you apply this in the future?"
        };

        _availableQuestions = new List<string>(_questions);
    }

    protected override void PerformActivity()
    {
        Console.WriteLine();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            if (_availableQuestions.Count == 0)
                _availableQuestions = new List<string>(_questions);

            int index = _random.Next(_availableQuestions.Count);
            string question = _availableQuestions[index];
            _availableQuestions.RemoveAt(index);

            Console.WriteLine($"\n{question}");
            ShowSpinner(4);
        }
    }
}