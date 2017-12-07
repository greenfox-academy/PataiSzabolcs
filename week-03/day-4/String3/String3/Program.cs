using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".
            string input = Console.ReadLine();
            Console.WriteLine(AddStar(input));
            Console.ReadLine();
        }
        static string AddStar(string input)
        {
            if (input.LastIndexOf("*") == input.Length - 2)
            {
                return input;
            }
            else
            {
                input = input.Insert(input.LastIndexOf("*") + 2, "*");
                return AddStar(input);
            }
        }
    }
}
