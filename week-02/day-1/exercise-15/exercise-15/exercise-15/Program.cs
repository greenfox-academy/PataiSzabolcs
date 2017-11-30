using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("Give me a distance in kilometer with an integer number:");
            string input = Console.ReadLine();
            int km = int.Parse(input);
            double mile = (double)km * 0.621371192;
            Console.WriteLine(km + " kms is " + mile + "in miles.");

            Console.ReadLine();
        }
    }
}