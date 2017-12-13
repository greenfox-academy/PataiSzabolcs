using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class AnagramMethod
    {
        public bool IsAnagram(string input1, string input2)
        {
            string ordered1 = String.Concat(Regex.Replace(Regex.Replace(input1.ToLower(), "-", ""), @"\s+", "").OrderBy(c => c));
            string ordered2 = String.Concat(Regex.Replace(Regex.Replace(input2.ToLower(), "-", ""), @"\s+", "").OrderBy(c => c));
            if (ordered1 == ordered2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
