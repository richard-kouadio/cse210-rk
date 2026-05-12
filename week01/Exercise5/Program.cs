using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine ("Welcome to the program!");
    }
   
    static string PromptUserName()
    {
        Console.Write("Please enter your name ");
        string name = Console.ReadLine();
        return name;
    }
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
    }
    static int PromptUserNumber()
    {
    Console.Write("Please enter your favorite number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
    }
        
}
