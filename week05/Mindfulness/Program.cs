using System;

class Program1
{ 
    static void Main(string[] args)
    {
        int choice = -1;
        
        while(choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:" +
                      "\n  1. Start breathing activity" +
                      "\n  2. Start reflecting activity" +
                      "\n  3. Start listing activity" +
                      "\n  4. Quit\n");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            // Menu Options
            if (choice == 1)
            {
                BreathingActivity b1 = new BreathingActivity();
                b1.Run();
            }
            else if (choice == 2)
            {
                ReflectingActivity r1 = new ReflectingActivity();
                r1.Run();
            }
            else if (choice == 3)
            {
                ListingActivity l1 = new ListingActivity();
                l1.Run();
            }
            else if (choice == 4)
            {
                Console.WriteLine("\nThanks for you using my program!!\n");
            }
            else
            {
                Console.WriteLine("\nYou must type a correct options!!");
            }
        }
    }
}
