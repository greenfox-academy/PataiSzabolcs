using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter

            int number = 7;

            Console.WriteLine(Sum(number));

            Console.ReadLine();
        }
        static int Sum (int input)
            {
            if (input % 2 == 0)
            {
                return (input + 1) * input / 2;
            }
            else
            {
                return (input + 1) * (input - 1) / 2 + (input + 1) / 2;
            }
            }
}
}