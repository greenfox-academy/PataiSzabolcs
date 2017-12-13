using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class LetterCounter
    {
        public Dictionary<char, int> CountLetters(string input)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (letterCount.ContainsKey(input[i]))
                {
                    letterCount[input[i]]++;
                }
                else
                {
                    letterCount.Add(input[i], 1);
                }
            }
            return letterCount;
        }
    }
}
