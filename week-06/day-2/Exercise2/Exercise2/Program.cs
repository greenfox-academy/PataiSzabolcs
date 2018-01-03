using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            int[] oddNumbers = n.Where(i => i % 2 == 1).ToArray();

            foreach (int number in oddNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
