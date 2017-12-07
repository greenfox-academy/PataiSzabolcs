using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny1
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).
            Console.WriteLine(Earcounter(5));
            Console.ReadLine();
        }
        static int Earcounter(int bunnies)
        {
            if (bunnies == 1)
            {
                return 2;
            }
            else
            {
                return  2 + Earcounter(bunnies - 1);
            }
        }
    }
}
