using System;
using System.Collections.Generic;
using System.Threading;


public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    // Methods
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine($"{_description}\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        _duration = seconds;

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        // Spinner
        string[] spinner = {"|","/","-", "\\","|","/","-", "\\"};
        int i = 0;

        // Loop to Display the spinner
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}