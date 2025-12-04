
public class BreathingActivity : Activity
{
    
    // Constructor
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration=10)
    {
    }
    
    public void Run()
    {
        SetName("Breathing");
        SetDescription("\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        DisplayStartingMessage();
        Console.WriteLine(GetDescription());
        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        SetDuration(seconds);

        // Show Spinner
        Console.Clear();
        Console.Write("Get ready...\n");
        ShowSpinner(seconds);

        
        Console.Write("Inhala...");
        ShowCountDown(seconds);
        Console.Write("Exhalar");

        DisplayEndingMessage();
    }
}