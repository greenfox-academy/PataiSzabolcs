using System;
using System.Collections.Generic;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };


            // Saturn is missing from the planetList
            // Insert it into the correct position

            planetList.Insert(5, "Saturn");

            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            //Console.WriteLine(planetList);
            Console.ReadLine();
        }
    }
}