using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("Give me a number:");
            string input = Console.ReadLine();
            int rows = int.Parse(input);

            for (int i = 0; i < rows; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        Console.Write("%");
                    }
                }
                else if (i == rows -1)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        Console.Write("%");
                    }
                }
                else
                {
                    Console.Write("%");
                    for (int k = 0; k < rows-2; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}