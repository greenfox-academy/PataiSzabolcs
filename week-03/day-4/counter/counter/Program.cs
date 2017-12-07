using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter(15);
            Console.ReadLine();
        }

        static int Counter(int n)
        {
            Console.WriteLine(n);
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return Counter(n - 1);
            }
        }
    }
}
