using System;
using System.Threading;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        ShowSpinner(2);

        Console.WriteLine(
            $"You completed the {_activityName} for {_duration} seconds."
        );

        ShowSpinner(3);
    }


    public void ShowSpinner(int seconds)
    {
        string[] animation = { "|", "/", "-", "\\" };

        DateTime end =
            DateTime.Now.AddSeconds(seconds);

        int index = 0;

        while (DateTime.Now < end)
        {
            Console.Write(animation[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            index++;

            if (index >= animation.Length)
            {
                index = 0;
            }
        }
    }


    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}