using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
    {
        public List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public void Print()
        {
            for (int i = 0; i < Things.Count; i++)
            {
                if (Things[i].Completed)
                {
                    Console.WriteLine("{0}. [x] {1}", i + 1, Things[i].Name);
                }
                else
                {
                    Console.WriteLine("{0}. [ ] {1}", i + 1, Things[i].Name);
                }
            }
            {
                Console.WriteLine();
            }
        }
    }
}