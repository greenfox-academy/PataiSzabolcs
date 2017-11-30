using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int storedNumber = 15;

            while (true)
            {
                Console.WriteLine("Guess a number:");
                string input = Console.ReadLine();
                int guessedNumber = int.Parse(input);
                if (guessedNumber < storedNumber)
                {
                    Console.WriteLine("The stored number is higher");
                }
                else if (guessedNumber > storedNumber)
                {
                    Console.WriteLine("The stored number is lower");
                }
                else
                {
                    Console.WriteLine("You found the number: " + storedNumber);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}