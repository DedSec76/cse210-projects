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