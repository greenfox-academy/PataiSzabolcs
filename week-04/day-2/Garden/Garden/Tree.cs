using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Tree : Plant
    {
        public Tree(string color)
        {
            Color = color;
            Type = " Tree";
            Water = 0;
            Absorbation = 0.4;
            WaterNeed = 10;
            Thirsty = (WaterNeed > Water);
        }
    }
}
