using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReversedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that decrypts reversed-lines.txt

            ReverseLine(@"C:\Users\Szabi\Desktop\reversed-lines.txt", @"C:\Users\Szabi\Desktop\decrypt2.txt");
        }
        static void ReverseLine(string sourceFilename, string targetFilename)
        {
            string[] lines = File.ReadAllLines(sourceFilename);

            for (int i = 0; i < lines.Length; i++)
            {
                char[] charArray = lines[i].ToCharArray();
                string reverse = String.Empty;

                for (int j = charArray.Length; j > 0; j--)
                {
                    reverse += charArray[j - 1];
                }
                lines[i] = reverse;
            }
            File.WriteAllLines(targetFilename, lines);            
        }
    }
}
