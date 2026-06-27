using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int GetScore()
    {
        return _score;
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int targetCount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
        }

        Console.WriteLine("Goal created!");
        Pause();
    }

    public void ListGoals()
    {
        Console.Clear();

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
        }
        else
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
            }
        }

        Pause();
    }

    public void RecordEvent()
    {
        Console.Clear();

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            Pause();
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber < 1 || goalNumber > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            Pause();
            return;
        }

        Goal selectedGoal = _goals[goalNumber - 1];
        int earnedPoints = selectedGoal.RecordEvent();

        _score += earnedPoints;

        Console.WriteLine($"You earned {earnedPoints} points!");
        Console.WriteLine($"You now have {_score} points.");
        Pause();
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Goals saved successfully.");
        Pause();
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            Pause();
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                _goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonusPoints = int.Parse(parts[4]);
                int targetCount = int.Parse(parts[5]);
                int timesCompleted = int.Parse(parts[6]);

                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints, timesCompleted));
            }
        }

        Console.WriteLine("Goals loaded successfully.");
        Pause();
    }

    private void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}