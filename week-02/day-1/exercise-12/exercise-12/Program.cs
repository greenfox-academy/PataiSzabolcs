using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            int side1 = 10;
            int side2 = 20;
            int side3 = 30;
            int surface = (side1 * side2 + side2 * side3 + side1 * side3) * 2;
            int volume = side1 * side2 * side3;

            Console.WriteLine("Surface Area: " + surface);
            Console.WriteLine("Volume: " + volume);
            Console.ReadLine();
        }
    }
}