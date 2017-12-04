using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt

            Decrypt(@"C:\Users\Szabi\Desktop\duplicated-chars.txt", @"C:\Users\Szabi\Desktop\decrypted.txt");
        }
        static void Decrypt(string sourceFilename, string targetFilename)
        {
            string input = File.ReadAllText(sourceFilename);
            char[] characters = input.ToCharArray();
            char[] newcharacters = new char[characters.Length];
            int j = 0;
            for ( int i = 0; i < newcharacters.Length; i++)
            {
                if (characters[i +j + 1] != '\n' && i + j + 1 != 1)
                {
                    j++;
                }                    
                newcharacters[i] = characters[i + j + 1];
            }
            string output = new string(newcharacters);
            string[] lines;
            lines = output.Split('\n');

            File.WriteAllLines(targetFilename, lines);
        }
    }
}
