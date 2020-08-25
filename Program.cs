using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Secret Number!");
            string userGuess = Console.ReadLine();
            CheckGuess(userGuess);
        }

        static void CheckGuess(string guess)
        {
            int userNumber = Convert.ToInt32(guess);
            int theAnswer = 42;
            if (userNumber == theAnswer)
            {
                Console.WriteLine("That is correct! You win!");
            }
            else
            {
                Console.WriteLine("Incorrect! You lose, you loser!");
            }

        }
    }
}