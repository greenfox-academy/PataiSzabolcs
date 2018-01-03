using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            int[] squaredOfPositives = n.Where(i => i > 0).Select(i => i * i).ToArray();

            foreach (int number in squaredOfPositives)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
