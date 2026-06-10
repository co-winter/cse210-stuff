using System;

public class Breathing : Exercise
{
    public Breathing()
    {
        _description =
            "This activity will help you relax by walking you through breathing in and out slowly.";
    }

    public void RunActivity()
    {
        DisplayStartMessage("Breathing");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            PauseCountdown(4);

            Console.Write("Breathe out... ");
            PauseCountdown(4);
        }

        DisplayEndMessage("Breathing");
    }
}