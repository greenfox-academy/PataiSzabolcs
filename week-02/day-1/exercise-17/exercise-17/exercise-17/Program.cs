using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Give me an integer:");
            string input1 = Console.ReadLine();
            int int1 = int.Parse(input1);

            Console.WriteLine("Give me another integer:");
            string input2 = Console.ReadLine();
            int int2 = int.Parse(input2);

            Console.WriteLine("For a change: give me an integer:");
            string input3 = Console.ReadLine();
            int int3 = int.Parse(input3);

            Console.WriteLine("Give me an integer (almost done):");
            string input4 = Console.ReadLine();
            int int4 = int.Parse(input4);

            Console.WriteLine("Give me the last integer:");
            string input5 = Console.ReadLine();
            int int5 = int.Parse(input5);

            Console.WriteLine("Sum: " + (int1 + int2 + int3 + int4 + int5) + " Average: " + ((int1 + int2 + int3 + int4 + int5) / 2));

            Console.ReadLine();
        }
    }
}