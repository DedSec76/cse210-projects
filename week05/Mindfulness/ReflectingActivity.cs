using System;
using System.Collections.Generic;

// Be sure to select random questions or prompts until all of them are used at least once in that session.
public class ReflectingActivity : Activity
{
    // Random Instance
    Random _random = new Random();

    //Copy List of Prompts
    private List<string> _remaining;
    private List<string> _prompts = new List<string>
    {"Think of a time when you stood up for someone else.",
     "Think of a time when you did something really difficult.",
     "Think of a time when you helped someone in need.",
     "Think of a time when you did something truly selfless."
    };
    
    private List<string> _questions = new List<string>
    {"Why was this experience meaningful to you?",
     "Have you ever done anything like this before?",
     "How did you get started?",
     "How did you feel when it was complete?",
     "What made this time different than other times when you were not as successful?",
     "What is your favorite thing about this experience?",
     "What could you learn from this experience that applies to other situations?",
     "What did you learn about yourself through this experience?",
     "How can you keep this experience in mind in the future?"
    };

    //Constructor
    public ReflectingActivity()
        :base("Reflecting",
              "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
              0)
    {
    }
    // Methods
    public void Run()
    {
        DisplayStartingMessage();
        
        DisplayPrompt();
        Console.Clear();

        // Run the time
        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < end)
        {
            DisplayQuestions();
            ShowSpinner(GetDuration() / 2);
            Console.WriteLine();
        }
        // good bye
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        if(_remaining == null || _remaining.Count == 0)
        {
            _remaining = new List<string>(_prompts);
        }

        int index = _random.Next(_remaining.Count);
        string prompt = _remaining[index];
        _remaining.RemoveAt(index);

        return prompt;
    }
    public string GetRandomQuestion()
    {
        if(_remaining == null || _remaining.Count == 0)
        {
            _remaining = new List<string>(_questions);
        }
        int index = _random.Next(_remaining.Count);
        string question = _remaining[index];
        _remaining.RemoveAt(index);

        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"\n --- {GetRandomPrompt()}");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
    }
    public void DisplayQuestions()
    {   
        Console.Write($"> {GetRandomQuestion()} ");
    }
}