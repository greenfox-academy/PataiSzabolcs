using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = { 'C', 'h', 'a', 'r', ' ', 'a', 'r', 'r', 'a', 'y', ' ', 'b', 'e', 'c', 'o', 'm', 'e', 's', ' ', 'a', ' ', 's', 't', 'r', 'i', 'n', 'g', '.' };



            string text = String.Join("", charArray.Select(o => o.ToString()).ToArray());

            Console.WriteLine(text);

            Console.ReadLine();
           

        }
    }
}
