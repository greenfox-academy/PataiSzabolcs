using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        public int Number { get; set; }

        public static Random random = new Random();

        public void Roll()
        {
            Number = random.Next(1, 7);
        }

        public int GetCurrent()
        {
            return Number;
        }

        public void Reroll()
        {
            Number = random.Next(1, 7);
        }
    }
}
