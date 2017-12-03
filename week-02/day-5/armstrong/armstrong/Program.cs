using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:");
            string input = Console.ReadLine();
            long number = long.Parse(input);
            long length = (long)Math.Floor(Math.Log10(number) + 1);
            if (number == Armstrong(number))
            {
                Console.WriteLine("The " + number + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("The " + number + " is not an Armstrong number.");
            }
            Console.ReadLine();
        }
        static long Armstrong(long number)
        {
            long sum = 0;
            long length = (long)Math.Floor(Math.Log10(number) + 1);

            for (int i = 0; i < length; i++)
                {
                    long digit = (number / (long)Math.Pow(10, length - 1 - i)) % 10;
                    long exponent = (long)Math.Pow(digit, length);
                    sum = sum + exponent; 
                }
            return sum;
        }
    }
}
