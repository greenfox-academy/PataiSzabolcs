using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class ElectricGuitar : StringedInstrument
    {
        public override string Sound()
        {
            return "twangs";
        }

        public ElectricGuitar()
        {
            name = "Electric Guitar";
            numberOfStrings = 6;
        }

        public ElectricGuitar(int numberOfStrings)
        {
            name = "Electric Guitar";
            this.numberOfStrings = numberOfStrings;
        }
    }
}
