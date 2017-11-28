using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was
            Console.WriteLine("Give me a number:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            for (int i = 0; i < number; i += 2)
            {
                  for (int j = 0; j < (number-i-1) / 2; j++)
                  {
                      Console.Write(" ");
                  }
                  for (int j = 0; j < i+1; j++)
                  {
                      Console.Write("*");
                  }

                Console.Write("\n");
                //Console.WriteLine("*");
            }

            if (number % 2 == 0)
            {
                for (int i = 0; i < number; i += 2)
                {
                    for (int j = 0; j < (i + 1) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = number; j > i + 1; j--)
                    {
                        Console.Write("*");
                    }

                    Console.Write("\n");
                    //Console.WriteLine("*");
                }
            }
            else
            {
                for (int i = 0; i < number - 1; i += 2)
                {
                    for (int j = 0; j < (i+2) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < number-i-2; j++)
                    {
                        Console.Write("*");
                    }

                    Console.Write("\n");
                    //Console.WriteLine("*");
                }

            }
            Console.ReadLine();
        }
    }
}