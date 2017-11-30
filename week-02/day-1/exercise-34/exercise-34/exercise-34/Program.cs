using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Give me a number:");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int integer = 0;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter an integer:");
                string input1 = Console.ReadLine();
                integer = integer + int.Parse(input1);
            }
            Console.WriteLine("Sum: " + integer + " Average: " + ((double)integer / (double)number));
            Console.ReadLine();
        }
    }
}