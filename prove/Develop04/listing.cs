using System;
using System.Collections.Generic;

public class Listing : Exercise
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    private int _count;

    public Listing()
    {
        _description =
            "This activity will help you reflect on the good things in your life.";
    }

    public void RunActivity()
    {
        DisplayStartMessage("Listing");

        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to:");
        Console.WriteLine();

        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

        Console.WriteLine();
        Console.Write("You may begin in: ");
        PauseCountdown(5);

        _count = 0;

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items.");

        DisplayEndMessage("Listing");
    }
}