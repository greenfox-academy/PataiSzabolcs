using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Ain't nobody got time for that!";

            var characterFrequency = text.Select(c => c).GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count()).OrderByDescending(c => c.Value);

            foreach (var kv in characterFrequency)
            {
                Console.WriteLine(kv);
            }

            Console.ReadLine();
        }
    }
}
