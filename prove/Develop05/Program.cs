using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string choice = "";

        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine($"You have {manager.GetScore()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.CreateGoal();
            }
            else if (choice == "2")
            {
                manager.ListGoals();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save to: ");
                string filename = Console.ReadLine();
                manager.SaveGoals(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load from: ");
                string filename = Console.ReadLine();
                manager.LoadGoals(filename);
            }
            else if (choice == "5")
            {
                manager.RecordEvent();
            }
        }
    }
}