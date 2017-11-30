using System;
using System.Collections.Generic;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            string[] girlsArray = new string[5];
            girls.CopyTo(girlsArray);

            string[] boysArray = new string[6];
            boys.CopyTo(boysArray);


            for (int i = 0; i < 6; i++)
            {
                if (i < 5)
                {
                    order.Add(girlsArray[i]);
                }
                
                order.Add(boysArray[i]);
                
            }

            foreach (string name in order)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            
            //Console.WriteLine(order);
        }
    }
}