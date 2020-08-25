using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int theAnswer = new Random().Next(1, 100);
            int numOfGuesses = ChooseDifficulty();
            Console.Clear();
            Console.WriteLine("Guess the Secret Number from 1 to 100!");
            Console.WriteLine("--------------------------------------");

            if (numOfGuesses == 100)
            {
                // Cheater mode - infinite guesses
                bool gameWon = false;
                while (!gameWon)
                {
                    Console.Write("Keep guessing!  ");
                    gameWon = CheckGuess(theAnswer);
                }
            }
            else
            {
                // Regular mode - limited guesses
                bool gameWon = false;
                for (int i = 0; i < numOfGuesses; i++)
                {
                    Console.Write($"{numOfGuesses - i} guesses left!  ");

                    gameWon = CheckGuess(theAnswer);
                    if (gameWon)
                        break;
                }

                if (!gameWon)
                {
                    Console.Clear();
                    Console.WriteLine("You are out of guesses!");
                    Console.WriteLine($"The Secret Number was {theAnswer}");
                    Console.WriteLine();
                    Console.WriteLine("Better luck next time!");
                }
            }

            static int ChooseDifficulty()
            {
                Console.Clear();
                Console.WriteLine("Please choose a difficulty level:");
                Console.WriteLine(" (E)asy");
                Console.WriteLine(" (M)edium");
                Console.WriteLine(" (H)ard");
                Console.WriteLine(" (C)heater");
                string difficulty = Console.ReadLine();

                int numOfGuesses = 0;
                switch (difficulty.ToLower())
                {
                    case "e":
                    case "easy":
                        numOfGuesses = 8;
                        break;
                    case "m":
                    case "medium":
                    case "med":
                        numOfGuesses = 6;
                        break;
                    case "h":
                    case "hard":
                        numOfGuesses = 4;
                        break;
                    case "c":
                    case "cheater":
                        numOfGuesses = 100;
                        break;
                    default:
                        numOfGuesses = 1;
                        break;
                }

                return numOfGuesses;

            }

            static bool CheckGuess(int answer)
            {
                string userGuess = Console.ReadLine();
                int userNumber;
                if (!int.TryParse(userGuess, out userNumber))
                {
                    Console.WriteLine("Not a number!");
                    return false;
                }

                if (userNumber == answer)
                {
                    Console.WriteLine("That is correct! You win!");
                    return true;
                }
                else
                {
                    // Give hints to the user
                    if (userNumber < answer)
                    {
                        Console.WriteLine("Too low. Aim higher!");
                    }
                    else if (userNumber > answer)
                    {
                        Console.WriteLine("Too high. Bring it down.");
                        Console.WriteLine();
                    }
                    return false;
                }
            }
        }
    }
}