using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int mnumber = int.Parse(Console.ReadLine());

        int guess = -1;
        int cont = 0;
  

        while (mnumber != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            cont += 1;

            if (mnumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (mnumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        
        Console.WriteLine($"You have guessed a total of: {cont}");
    }
        
}
