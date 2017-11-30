using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot

            Console.WriteLine("Give me a number");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number <= 0)
            {
                Console.WriteLine("Not enough");
            }

            if (number == 1)
            {
                Console.WriteLine("One");
            }

            if (number == 2)
            {
                Console.WriteLine("Two");
            }

            if (number > 2)
            {
                Console.WriteLine("A lot");
            }
            Console.ReadLine();
        }
    }
}