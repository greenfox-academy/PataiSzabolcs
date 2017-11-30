using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("Give me a number:");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            Console.WriteLine("Give me another number:");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2 + " is bigger.");
            }
            Console.ReadLine();
        }
    }
}