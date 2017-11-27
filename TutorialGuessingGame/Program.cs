using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                int guess = 0;

                Console.WriteLine("Please guess a number between 1 and 10.");

                while (guess != correctNumber)
                {
                    string inputGuess = Console.ReadLine();

                    if (!int.TryParse(inputGuess, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number.");
                    }

                    guess = Int32.Parse(inputGuess);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "bethD.";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{appName}:  Version:  {appVersion} by {appAuthor}.");
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello, {inputName}, let's play a game!");
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
