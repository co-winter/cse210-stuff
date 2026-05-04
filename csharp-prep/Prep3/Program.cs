using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = 1;


        while (guess != magicNumber)
        {
            Console.Write("guess a number");
            int guessed = int.Parse(Console.ReadLine());

            if (magicNumber > guessed)
            {
                Console.Write("higher");
            }
            if (magicNumber < guessed)
            {
                Console.Write("lower");
            }
        }
    }
}