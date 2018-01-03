using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var numberFrequency = n.Select(i => i).GroupBy(i => i).ToDictionary(i => i.Key, i => i.Count());

            foreach (KeyValuePair<int, int> kv in numberFrequency)
            {
                Console.WriteLine(kv);
            }

            Console.ReadLine();
        }
    }
}
