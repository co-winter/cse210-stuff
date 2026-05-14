using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();

                entry.Date = DateTime.Now.ToShortDateString();
                entry.Prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(entry.Prompt);
                Console.Write("> ");
                entry.Response = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                journal.SaveToFile("journal.txt");
            }
            else if (choice == "4")
            {
                journal.LoadFromFile("journal.txt");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}