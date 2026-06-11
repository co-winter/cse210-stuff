using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();

            Console.Write("Select a choice: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing breathing = new Breathing();
                breathing.RunActivity();
            }
            else if (choice == "2")
            {
                Reflection reflection = new Reflection();
                reflection.RunActivity();
            }
            else if (choice == "3")
            {
                Listing listing = new Listing();
                listing.RunActivity();
            }
        }
    }
}