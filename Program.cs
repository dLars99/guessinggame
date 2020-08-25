using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Secret Number!");
            string userGuess = Console.ReadLine();
            Console.WriteLine(userGuess);
        }
    }
}