using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int theAnswer = new Random().Next(1, 100);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{4 - i} guesses left!");
                Console.WriteLine("Guess the Secret Number!");
                string userGuess = Console.ReadLine();
                int userNumber = Convert.ToInt32(userGuess);

                bool correctGuess = CheckGuess(userNumber, theAnswer);
                if (correctGuess)
                    break;
            }
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
                }
                return false;
            }

        }
    }
}