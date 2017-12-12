using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();

            Flower flower0 = new Flower("yellow");
            garden.AddPlant(flower0);
            Flower flower1 = new Flower("blue");
            garden.AddPlant(flower1);
            Tree tree0 = new Tree("purple");
            garden.AddPlant(tree0);
            Tree tree1 = new Tree("orange");
            garden.AddPlant(tree1);

            garden.CheckStatus();

            garden.Watering(40);
            garden.CheckStatus();

            garden.Watering(70);
            garden.CheckStatus();

            Console.ReadLine();
        }
    }
}
