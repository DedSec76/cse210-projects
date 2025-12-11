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
