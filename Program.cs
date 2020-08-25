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
            for (int i = 0; i < numOfGuesses; i++)
            {
                Console.WriteLine("Guess the Secret Number!");
                Console.WriteLine("------------------------");
                Console.Write($"{numOfGuesses - i} guesses left!  ");
                string userGuess = Console.ReadLine();
                int userNumber = Convert.ToInt32(userGuess);

                bool correctGuess = CheckGuess(userNumber, theAnswer);
                if (correctGuess)
                    break;
            }
        }

        static int ChooseDifficulty()
        {
            Console.Clear();
            Console.WriteLine("Please choose a difficulty level:");
            Console.WriteLine(" (E)asy");
            Console.WriteLine(" (M)edium");
            Console.WriteLine(" (H)ard");
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
                default:
                    numOfGuesses = 1;
                    break;
            }

            return numOfGuesses;

        }

        static bool CheckGuess(int guess, int answer)
        {
            if (guess == answer)
            {
                Console.WriteLine("That is correct! You win!");
                return true;
            }
            else
            {
                if (guess < answer)
                {
                    Console.WriteLine("Too low. Aim higher!");
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Too high. Bring it down.");
                    Console.WriteLine();
                }
                return false;
            }

        }
    }
}