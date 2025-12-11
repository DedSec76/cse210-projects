
// The console interface was improved to make it more dynamic and user-friendly for the end user.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        Console.WriteLine("=== Goal System ===");
        manager.Start();

        Console.WriteLine("¡Thank You for using my program!");
    }
}
