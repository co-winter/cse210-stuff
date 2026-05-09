using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userNumber = 2;
        while (userNumber != 0)
        {
            Console.Write("GIveme number");
            string typed = Console.ReadLine();
            userNumber = int.Parse(typed);
        }   

        if (userNumber != 0)
        {
            numbers.Add(userNumber);
        }



    }
}