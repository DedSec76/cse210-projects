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
                      "\n  3. Start reflecting activity" +
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
                Console.WriteLine("\nEscogiste opcion 2\n");
            }
            else if (choice == 3)
            {
                Console.WriteLine("\nEscogiste opcion 3\n");
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

        




        //Activity a1 = new Activity("Breathing", "Esta actividad te ayudará a relajarte y pensar con claridad", 10);
        /*BreathingActivity b1 = new BreathingActivity("Breathing","Esta actividad te ayudará a relajarte y pensar con claridad", 30);
        b1.DisplayStartingMessage();
        Console.WriteLine("Esta actividad te ayudará a relajarte y pensar con claridad");
        Console.Write("Get ready...\n");
        b1.ShowSpinner(10);
        b1.ShowCountDown(b1.GetDuration());
        b1.DisplayEndingMessage();*/
        
    }
}
