using System;

class Program
{
    static void Main(string[] args)
    {
        reference reference = new reference("Proverbs", "3", 5, 6);

        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths";

        scripture scripture = new scripture(reference, text);

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