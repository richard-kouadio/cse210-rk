using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       List<int> number = new List<int>();
       int userNumber = -1;
       while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            userNumber = int.Parse(input);

            if (userNumber != 0)
            {
                number.Add(userNumber);
            }
        } 

    }
}