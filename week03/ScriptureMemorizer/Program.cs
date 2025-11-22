using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Proverbs", 3,5,6);

        string text = "Confía en el Señor con todo tu corazón y no te apoyes en tu propia prudencia";

        Scripture scr1 = new Scripture(r1, text);


        while (!scr1.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scr1.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                break;
            }

            scr1.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine("Finish...");
    }
}