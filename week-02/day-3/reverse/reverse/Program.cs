using System;
using System.Linq;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            
            Console.WriteLine(ReverseString(reversed));
            Console.ReadLine();
        }
        static string ReverseString(string text)
        {
            char[] array = new char[text.Length];
            array = text.ToCharArray();
            Array.Reverse(array);
            string reversed = new string(array);
            return reversed;
        }
    }
}