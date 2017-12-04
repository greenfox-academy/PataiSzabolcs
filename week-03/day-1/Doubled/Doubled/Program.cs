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
            //StreamReader reader = new StreamReader(sourceFilename);
            //StreamWriter writer = new StreamWriter(targetFilename);

            string input = File.ReadAllText(sourceFilename);
            char[] characters = input.ToArray();
            char[] newcharacters = new char[characters.Length];
            int j = 0;
            for ( int i = 0; i < newcharacters.Length; i++)
            {
                try
                {
                    if (characters[i +j + 1] != '\n' && i + j + 1 != 1)
                    {
                        j++;
                    }
                    newcharacters[i] = characters[i + j + 1];

                }
                catch (Exception)
                {
                    
                }
            }
            //writer.Write(newcharacters);
            //writer.Close();

            string output = new string(newcharacters);
            File.WriteAllLines(targetFilename, output);
            //foreach (char character in newcharacters)
            //{
            //    Console.Write(character);
            //}
            Console.ReadLine();
        }
    }
}
