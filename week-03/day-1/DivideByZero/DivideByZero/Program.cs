using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0

            Console.WriteLine("Give me a number:");
            string input = Console.ReadLine();
            DivideTenBy(int.Parse(input));
            Console.ReadLine();
        }
        static void DivideTenBy(int number)
        {
            try
            {
                Console.WriteLine(10 / number);
            }
            catch (Exception)
            {
                Console.WriteLine("fail");
            }
        }
    }
}
