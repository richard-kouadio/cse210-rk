using System;

class Program
{
    static void Main(string[] args)
    {

        // Creativity:
        // Added activity tracking through completion messages
        // and enhanced spinner animations.


        int choice = 0;


        while(choice != 4)
        {

            Console.Clear();

            Console.WriteLine(
            "Mindfulness Program"
            );

            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");


            Console.Write(
                "Choose an option: "
            );


            choice = int.Parse(Console.ReadLine());


            if(choice == 1)
            {
                BreathingActivity activity =
                    new BreathingActivity();

                activity.Run();
            }


            else if(choice == 2)
            {
                ReflectingActivity activity =
                    new ReflectingActivity();

                activity.Run();
            }


            else if(choice == 3)
            {
                ListingActivity activity =
                    new ListingActivity();

                activity.Run();
            }


        }


        Console.WriteLine("Goodbye!");
    }
}