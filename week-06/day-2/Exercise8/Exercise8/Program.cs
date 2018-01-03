using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "ThiS TexT ContaINS Some UPPERCASE LettERs";

            var uppercaseCharacters = text.Where(c => char.IsUpper(c)).GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count()).OrderByDescending(c => c.Key);

            foreach (var kv in uppercaseCharacters)
            {
                if (kv.Value > 1)
                {
                    Console.WriteLine($"There are {kv.Value} uppercase {kv.Key} characters in the string.");
                }
                else
                {
                    Console.WriteLine($"There is {kv.Value} uppercase {kv.Key} character in the string.");
                }
            }

            Console.ReadLine();
        }
    }
}
