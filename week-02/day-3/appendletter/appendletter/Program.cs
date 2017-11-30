using System;
using System.Collections.Generic;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.

            for (int i = 0; i < far.Count; i++)
            {
                far[i] = far[i] + 'a';
            }

            foreach (string animal in far)
            {
                Console.WriteLine(animal);
            }

            Console.ReadLine();

            //Console.WriteLine(far);
        }
    }
}