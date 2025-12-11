using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(30, 4.8));
        activities.Add(new Swimming(20, 15));
        activities.Add(new Bicycles(30, 2.5));

        Console.Clear();
        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSumary());
        }
    }
}