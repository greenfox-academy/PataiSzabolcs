using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Plant
    {
        public string Type;
        public string Color;
        public double Water;
        public double Absorbation;
        public double WaterNeed;
        public bool Thirsty;

        public void Needswater()
        {
            if (Water < WaterNeed)
            {
                Console.WriteLine($"The {Color} {Type} needs water.");
            }
            else
            {
                Console.WriteLine($"The {Color} {Type} doesn't need water.");
            }
        }
    }
}
