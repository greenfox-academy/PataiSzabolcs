using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts reversed-order.txt

            ReverseOrder(@"C:\Users\Szabi\Desktop\reversed-order.txt", @"C:\Users\Szabi\Desktop\decrypt3.txt");
        }
        static void ReverseOrder(string sourceFilename, string targetFilename)
        {
            string[] lines = File.ReadAllLines(sourceFilename);
            string[] reverselines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                reverselines[i] = lines[lines.Length - 1 - i];
            }
            File.WriteAllLines(targetFilename, reverselines);
        }
    }
}
