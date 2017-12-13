using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class FibonacciCalculator
    {
        public int ComputeFibonacci(int index)
        {
            if (index == 0)
            {
                return 0;
            }
            else if (index == 1)
            {
                return 1;
            }
            else
            {
                return ComputeFibonacci(index - 1) + ComputeFibonacci(index - 2);
            }
        }
    }
}
