using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class UniqueChars
    {
        // Create a method called `UniqueCharacters` that takes a string as parameter
        // and returns a list with the unique letters of the given string
        // Create basic unit tests for it with at least 3 different test cases
        // Print the characters from that list in the following format:
        // "n", "g", "r", "m"

        public List<char> UniqueCharacters(string input)
        {
            List<char> uniqueCharList = new List<char>();
            List<char> nonuniqueCharList = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!uniqueCharList.Contains(input[i]) && !nonuniqueCharList.Contains(input[i]))
                {
                    uniqueCharList.Add(input[i]);
                }
                else
                {
                    nonuniqueCharList.Add(input[i]);
                    try
                    {
                        uniqueCharList.RemoveAt(uniqueCharList.IndexOf(input[i]));
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            return uniqueCharList;
        }
    }
}
