using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code

            string temp = list[2];
            list[2] = list[5];
            list[5] = temp;

            // Also, print the sentence to the output with spaces in between.

            foreach (string word in list)
            {
                Console.Write(word);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}