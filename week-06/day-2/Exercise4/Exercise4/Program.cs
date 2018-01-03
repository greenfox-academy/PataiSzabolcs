using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var filteredNumbers1 =
                from i in n
                where i * i > 20
                select i;
            
            foreach (int number in filteredNumbers1)
            {
                Console.WriteLine(number);
            }

            n.Where(i => i * i > 20).ToList().ForEach(i => Console.WriteLine(i));

            Console.ReadLine();
        }
    }
}
