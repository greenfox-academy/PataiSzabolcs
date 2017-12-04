using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            Console.WriteLine(CopyFile(@"C:\Users\Szabi\Desktop\my-file.txt", @"C:\Users\Szabi\Desktop\my-file1.txt"));
            Console.ReadLine();
        }
        static bool CopyFile(string sourceFilename, string targetFilename)
        {
            try
            {
            string[] source = File.ReadAllLines(sourceFilename);
            File.WriteAllLines(targetFilename, source);
            return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
