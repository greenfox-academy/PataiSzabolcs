using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.WriteLine("Give me a number:");
            string input = Console.ReadLine();
            int rows = int.Parse(input);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i -1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}