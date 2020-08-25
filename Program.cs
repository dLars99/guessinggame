using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Your Guess ({i})>");
                Console.WriteLine("Guess the Secret Number!");
                string userGuess = Console.ReadLine();
                bool correctGuess = CheckGuess(userGuess);
                if (correctGuess)
                    break;
            }
        }

        static bool CheckGuess(string guess)
        {
            int userNumber = Convert.ToInt32(guess);
            int theAnswer = 42;

            if (userNumber == theAnswer)
            {
                Console.WriteLine("That is correct! You win!");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect! Try better!");
                return false;
            }

        }
    }
}