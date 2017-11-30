using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Give me a number:");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            Console.WriteLine("Give me another number:");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            if (number2 <= number1)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                for (int i = 0; i < number2 - number1; i++)
                {
                    Console.WriteLine(i + number1);
                }
            }
            Console.ReadLine();
        }
    }
}