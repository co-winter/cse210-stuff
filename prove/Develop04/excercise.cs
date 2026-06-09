using System;
using System.Threading;

public class Exercise
{
    protected string _description = "";
    protected int _duration;

    public void DisplayStartMessage(string activityName)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityName} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        PauseSpinner(3);
    }

    public void DisplayEndMessage(string activityName)
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        PauseSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed the {activityName} Activity for {_duration} seconds.");
        PauseSpinner(3);
    }

    public void PauseSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i >= spinner.Length)
            {
                i = 0;
            }
        }
    }

    public void PauseCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }
}