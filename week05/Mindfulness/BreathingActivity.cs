using System;

public class BreathingActivity : Activity
{

    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing slowly."
        )
    {

    }


    public void Run()
    {
        DisplayStartingMessage();


        DateTime end =
            DateTime.Now.AddSeconds(GetDuration());


        while(DateTime.Now < end)
        {
            Console.WriteLine();

            Console.Write("Breathe in...");
            ShowCountDown(5);

            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountDown(5);
        }


        DisplayEndingMessage();
    }
}