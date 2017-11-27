using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // Than prints "Odd" if the number is odd, or "Even" it it is even.

            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number % 2 == 1)
            {
                Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine("Even");
            }

            Console.ReadLine();
        }
    }
}