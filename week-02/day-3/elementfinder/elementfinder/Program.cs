using System;
using System.Collections.Generic;

namespace ElementFinder
{
    public class ElementFinder
    {
        public static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };

            // Check if the arrayList contains "7" if it contains print "Hoorray" otherwise print "Noooooo"
            // Do this again with a different solution using different list functions!

            if (List.Contains(7))
            {
                Console.WriteLine("Hoorray!");
            }
            else
            {
                Console.WriteLine("Noooooo");
            }

            if (List.Exists(i => i == 7))
            {
                Console.WriteLine("Hoorray!");
            }
            else
            {
                Console.WriteLine("Noooooo");
            }

            if (List.IndexOf(7) == -1)
            {
                Console.WriteLine("Noooooo");
            }



            if (List.BinarySearch(7) == -6)
            {
                Console.WriteLine("Noooooo");
            }


            /*if (List[List.Count] == 7)
            {
                Console.WriteLine("Hooray!");
            }
            else
            {
                Console.WriteLine("Noooooo");
            }*/

            Console.ReadLine();
        }
    }
}