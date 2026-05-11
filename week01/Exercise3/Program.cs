using System;

class Program
{
    static void Main(string[] args)
 { 
    Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    int number = int.Parse(input);
    
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(i);
    }
 }
}