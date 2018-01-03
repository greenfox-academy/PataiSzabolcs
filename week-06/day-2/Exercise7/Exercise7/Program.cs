using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            cities.Where(c => c.First() == 'A' && c.Last() == 'I').ToList().ForEach(c => Console.WriteLine(c));

            Console.ReadLine();
        }
    }
}
