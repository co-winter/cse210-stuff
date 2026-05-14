using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> Prompts = new List<string>()
    {
        "What made you happy today?",
        "What did you learn today?",
        "What was the most challenging part of your day?",
        "Who did you talk to today?",
        "What are you grateful for today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }
}