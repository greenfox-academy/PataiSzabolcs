using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueChars uniqueChars = new UniqueChars();
            List<char> charList = new List<char>();
            charList = uniqueChars.UniqueCharacters("Hey Joe, Where are you going with that gun in your hand?");
            foreach (char character in charList)
            {
                Console.Write($"\" {character} \", ");
            }
            Console.ReadLine();
        }
    }
}
