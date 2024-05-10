using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "yes";
        while (answer == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int guess = -1;
            for (int numGuess = 1; guess != magicNumber; numGuess++)
            {
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {numGuess} guesses");
                    Console.WriteLine("Do you want to keep playing?");
                    answer = Console.ReadLine();
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            }
        }
    }
}