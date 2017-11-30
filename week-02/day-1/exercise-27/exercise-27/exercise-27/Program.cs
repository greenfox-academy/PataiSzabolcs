using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints the numbers from 1 to 100.
            // But for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”.
            // For numbers which are multiples of both three and five print “FizzBuzz”.

            for (int i = 0; i < 100; i++)
            {
                if ((i + 1) % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i + 1);
                }
            }
            Console.ReadLine();
        }
    }
}