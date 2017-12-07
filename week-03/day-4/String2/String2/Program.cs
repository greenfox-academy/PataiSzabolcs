using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.
            string input = Console.ReadLine();
            Console.WriteLine(Remove(input));
            Console.ReadLine();
        }
        static string Remove(string input)
        {
            if (input.IndexOf("x") == -1)
            {
                return input;
            }
            else
            {
                input = input.Remove(input.IndexOf("x"), 1);
                return Remove(input);
            }
        }
    }
}
