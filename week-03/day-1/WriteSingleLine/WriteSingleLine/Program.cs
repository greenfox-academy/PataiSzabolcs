using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            string path = @"C:\Users\Szabi\Desktop\my-file.txt";
                try
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine("Patai Szabolcs");
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                finally
                {
                    Console.ReadLine();
                }

        }
    }
}
