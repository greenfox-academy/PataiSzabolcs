using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            int[] evenNumbers = n.Where(i => i % 2 == 0).ToArray();
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
