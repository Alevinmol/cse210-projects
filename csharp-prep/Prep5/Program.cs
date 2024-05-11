using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string user = Console.ReadLine();
            return user;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number:");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int x)
        {
            int square = x * x;
            return square;
        }

        static void DisplayResult(string uName, int uSquareNumber)
        {
            Console.WriteLine($"{uName}, the square of your number is: {uSquareNumber}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }
}