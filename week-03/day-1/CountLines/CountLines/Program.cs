using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            Console.WriteLine("Give me a filename:");
            int numberOfLines = CountLines(Console.ReadLine());
            Console.WriteLine(numberOfLines);
            Console.ReadLine();

        }
        static int CountLines(string filename)
        {
            try
            {
                string[] array = File.ReadAllLines(@filename);
                return array.Length;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
