using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // ======================
    //   CYBERPUNK UI
    // ======================

    private void Title(string text)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n█████████████████████████████████████████");
        Console.Write("▓▓▓ ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(text.ToUpper());
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" ▓▓▓");
        Console.WriteLine("█████████████████████████████████████████\n");
        Console.ResetColor();
    }

    private void Pause()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("\n Press ENTER to continue...");
        Console.ResetColor();
        Console.ReadLine();
        Console.Clear();
    }

    public void DisplayPlayerInfo()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"SCORE :: {_score}\n");
        Console.ResetColor();
    }

    // ======================
    //      MAIN LOOP
    // ======================

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Title(" GOAL SYSTEM ");
            DisplayPlayerInfo();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Select an option:\n");
            Console.WriteLine("  1 -> Create Goal");
            Console.WriteLine("  2 -> List Goals");
            Console.WriteLine("  3 -> Record Event");
            Console.WriteLine("  4 -> Save Goals");
            Console.WriteLine("  5 -> Load Goals");
            Console.WriteLine("  6 -> Exit\n");
            Console.ResetColor();

            Console.Write("-> Option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": running = false; break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nX Invalid option.");
                    Console.ResetColor();
                    Pause();
                    break;
            }
        }
    }

    // ======================
    //    DISPLAY GOALS
    // ======================

    public void ListGoalDetails()
    {
        Console.Clear();
        Title(" ACTIVE GOALS");

        if (_goals.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No goals created yet.");
            Console.ResetColor();
            Pause();
            return;
        }

        foreach (var goal in _goals)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("º " + goal.GetDetailsString());
            Console.ResetColor();
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nTOTAL SCORE :: {_score}");
        Console.ResetColor();

        Pause();
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        Console.ResetColor();
    }

    // ======================
    //     CREATE GOAL
    // ======================

    public void CreateGoal()
    {
        Console.Clear();
        Title("+ CREATE NEW GOAL");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Goal Types:");
        Console.WriteLine("  1. Simple");
        Console.WriteLine("  2. Eternal");
        Console.WriteLine("  3. Checklist\n");
        Console.ResetColor();

        Console.Write("-> Goal type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("Required completions: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus when finished: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nx Invalid goal type.");
                Console.ResetColor();
                Pause();
                return;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n Goal successfully created!!");
        Console.ResetColor();
        Pause();
    }

    // ======================
    //   RECORD EVENT
    // ======================

    public void RecordEvent()
    {
        Console.Clear();
        Title(" RECORD EVENT");

        if (_goals.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No goals available.");
            Console.ResetColor();
            Pause();
            return;
        }

        ListGoalNames();
        Console.Write("\nSelect goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("x Invalid index.");
            Console.ResetColor();
            Pause();
            return;
        }

        Goal goal = _goals[index];

        goal.RecordEvent();
        _score += goal.GetPoints();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n Event recorded. Earned {goal.GetPoints()} points.");
        Console.ResetColor();

        if (goal is ChecklistGoal cg && cg.IsComplete())
        {
            _score += cg.GetBonus();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" BONUS ACHIEVED! Extra {cg.GetBonus()} points!");
            Console.ResetColor();
        }

        Pause();
    }

    // ======================
    //       SAVE
    // ======================

    public void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(_score);
            foreach (var goal in _goals)
            {
                sw.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n Goals saved successfully.");
        Console.ResetColor();
        Pause();
    }

    // ======================
    //        LOAD
    // ======================

    public void LoadGoals()
    {
        Console.Clear();
        Title(" LOAD GOALS");

        if (!File.Exists("goals.txt"))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("x No save file found.");
            Console.ResetColor();
            Pause();
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] p = lines[i].Split('|');

            switch (p[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(p[1], p[2], int.Parse(p[3])));
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(p[1], p[2], int.Parse(p[3])));
                    break;

                case "ChecklistGoal":
                    var cg = new ChecklistGoal(
                        p[1], p[2], int.Parse(p[3]),
                        int.Parse(p[5]), int.Parse(p[6])
                    );

                    typeof(ChecklistGoal)
                        .GetField("_amountCompleted", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .SetValue(cg, int.Parse(p[4]));

                    _goals.Add(cg);
                    break;
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" Goals loaded successfully.");
        Console.ResetColor();

        Pause();
    }
}
