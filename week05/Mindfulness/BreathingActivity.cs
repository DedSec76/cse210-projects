using System;

public class BreathingActivity : Activity
{
    
    // Constructor
    public BreathingActivity()
        : base("Breathing",
               "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
               0)
    {
    }
    
    public void Run()
    {
        DisplayStartingMessage();
    
        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        SetDuration(seconds);

        // Show Spinner
        Console.Clear();
        Console.Write("Get ready...\n");
        ShowSpinner(5);

        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        while(DateTime.Now < end)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}