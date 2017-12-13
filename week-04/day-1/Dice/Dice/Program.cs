using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dice> dices = new List<Dice>();
            for (int i = 0; i < 6; i++)
            {
                dices.Add(new Dice());
            }
            for (int i = 0; i < dices.Count; i++)
            {
                dices[i].Roll();
                
            }
            foreach (Dice dice in dices)
            {
                Console.WriteLine(dice.Number);
            }
            Console.ReadLine();
        }
    }
}
