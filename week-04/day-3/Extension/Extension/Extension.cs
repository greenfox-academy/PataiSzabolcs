using System;
using System.Collections.Generic;
using System.Linq;

namespace Extension
{
    public class Extension
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int MaxOfThree(int a, int b, int c)
        {
            List<int> numbers = new List<int> {a, b, c };
            return numbers.Max();
        }

        public int Median(List<int> pool)
        {
            pool.Sort();
            if (pool.Count % 2 == 1)
            {
                return pool[(pool.Count - 1) / 2];
            }
            else
            {
                return (pool[pool.Count / 2] + pool[(pool.Count - 2) / 2]) / 2;
            }
        }

        public bool IsVowel(char c)
        {
            return (new List<char>() { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű', }).Contains(c);
        }

        public string Translate(string hungarian)
        {
            string teve = hungarian;
            int length = teve.Length;
            for (int i = 0; i < length; i++)
            {
                char c = teve[i];
                if (IsVowel(c))
                {
                    teve = string.Join(c + "v" + c, teve.Split(c));
                    i += 2;
                    length += 2;
                }
            }

            return teve;
        }
    }
}