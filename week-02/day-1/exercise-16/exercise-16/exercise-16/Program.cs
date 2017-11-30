using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have

            Console.WriteLine("Give me the number of chickens the farmer has.");
            string input1 = Console.ReadLine();
            int chickens = int.Parse(input1);
            Console.WriteLine("Give me the number of pigs the farmer has.");
            string input2 = Console.ReadLine();
            int pigs = int.Parse(input2);
            Console.WriteLine("The farmer\'s animals have " + (2 * chickens + 4 * pigs) + " legs alltogether.");
            Console.ReadLine();

        }
    }
}