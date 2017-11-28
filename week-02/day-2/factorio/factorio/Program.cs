using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            int number = 6;

            Console.WriteLine(Factorio(number));


            Console.ReadLine();
        }
        // Disclaimer: I have just seen this video in the weekend so it was easier:
        // https://www.youtube.com/watch?v=Mv9NEXX1VHc
        static int Factorio(int input)
        {
            if (input == 1 || input == 0)
            {
                return 1;
            }
            else
            {
                return input * Factorio(input-1);
            }
        }
    }
}