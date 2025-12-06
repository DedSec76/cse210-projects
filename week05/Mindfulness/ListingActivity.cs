using System;
using System.Collections.Generic;

// Be sure to select random questions or prompts until all of them are used at least once in that session.
public class ListingActivity : Activity
{
    private int _count;
    // Copy list of prompts
    private List<string> _remaining;
    private List<string> _prompts = new List<string>
    {"Who are people that you appreciate?",
     "What are personal strengths of yours?",
     "Who are people that you have helped this week?",
     "When have you felt the Holy Ghost this month?",
     "Who are some of your personal heroes?"
    };

    public ListingActivity()
        :base("Listing",
              "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
              0)
    {}

    public void Run()
    {
        DisplayStartingMessage();

        GetRandomPrompt();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while(DateTime.Now < end)
        {
            GetListFromUser();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        
        Random _random = new Random();

        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        
        // The items on the list are not repeated
        if (_remaining == null || _remaining.Count == 0)
        {
            _remaining = new List<string>(_prompts);
        }
        int index = _random.Next(_remaining.Count);
        Console.WriteLine($" --- {_remaining[index]}");
        _remaining.RemoveAt(index);

        //Starting
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
    }
    public List<string> GetListFromUser()
    {
        List<string> _listU = new List<string>();

        Console.Write("> ");
        string input = Console.ReadLine();
        if (input != "")
        {
            _listU.Add(input);
        }

        return _listU;
    }
}