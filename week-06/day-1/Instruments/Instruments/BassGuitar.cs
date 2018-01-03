using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class BassGuitar : StringedInstrument
    {
        public override string Sound()
        {
            return "says Duum-duum-duum";
        }

        public BassGuitar()
        {
            name = "Bass Guitar";
            numberOfStrings = 4;
        }

        public BassGuitar(int numberOfStrings)
        {
            name = "Bass Guitar";
            this.numberOfStrings = numberOfStrings;
        }
    }
}
