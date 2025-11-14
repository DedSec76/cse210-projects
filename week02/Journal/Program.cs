using System;
using System.IO;


// Improvement: Added a CSV-compatible save and file upload feature.
class Program
{
    static void Main(string[] args)
    {
        // Generates random prompt
        PromptGenerator aPromp = new PromptGenerator();

        // Save to journal
        Journal aJournal = new Journal();

        // Interactive Menu 
        Console.WriteLine("Welcome to the Journal Program!");

        int choice = -1;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:\n");
            Console.Write(
                "1. Write\n" +
                "2. Display\n" +
                "3. Load\n" +
                "4. Save\n" +
                "5. Quit\n");

            Console.Write("What would you like do?: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string dateText = DateTime.Now.ToShortDateString();
                string prompt = aPromp.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("> ");
                string response = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Entry not added. Response cannot be empty.");
                    continue;
                }

                // Get an entry
                Entry anEntry = new Entry();

                anEntry._date = dateText;
                anEntry._promptText = prompt;
                anEntry._entryText = response;

                aJournal.AddEntry(anEntry);
            }

            else if (choice == 2)
            {
                aJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("What is the Filename? ");
                string filename = Console.ReadLine();

                aJournal.LoadFromFile(filename);
            }

            else if (choice == 4)
            {
                Console.Write("What is the Filename? ");
                string filename = Console.ReadLine();

                aJournal.SaveToFile(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid option. Please select 1–5.");
            }
        }
    }
}
