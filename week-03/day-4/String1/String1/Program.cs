using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.
            string input = Console.ReadLine();
            Console.WriteLine(Replacer(input));
            Console.ReadLine();
        }
        static string Replacer(string input)
        {
            if (input.IndexOf("x") == -1)
            {
                return input;
            }
            else
            {
                int index = input.IndexOf("x");
                input = input.Remove(index, 1);
                input = input.Insert(index, "y");
                return Replacer(input);
            }
        }
    }
}
