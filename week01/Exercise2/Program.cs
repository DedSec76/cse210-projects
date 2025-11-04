using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string userInput = Console.ReadLine();
        float grade = float.Parse(userInput);

        if (grade >= 90)
        {
            Console.WriteLine("Your grade percentage is: A");
        }

        else if (grade >= 80)
        {
            Console.WriteLine("Your grade percentage is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade percentage is: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade percentage is: D");
        }
        else
        {
            Console.WriteLine("Your grade percentage is: F");
        }

        Console.WriteLine("");

        if (grade >= 70)
        {
            Console.WriteLine("You Passed!!");
        }
        else
        {
            Console.WriteLine("You didn't pass. Better luck next time!");
        }
    }
}