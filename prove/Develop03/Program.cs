using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "3", 5, 6);

        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths";

        Scripture scripture = new Scripture(reference, text);

        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Clear();

            scripture.DisplayScripture();

            if (scripture.AllWordsHidden())
            {
                continueProgram = false;
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue or type quit");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                continueProgram = false;
            }
            else
            {
                scripture.HideWords();
            }
        }
    }
}