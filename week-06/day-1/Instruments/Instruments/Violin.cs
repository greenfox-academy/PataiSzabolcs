using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class Violin : StringedInstrument
    {
        public override string Sound()
        {
            return "screeches";
        }

        public Violin()
        {
            name = "Violin";
            numberOfStrings = 4;
        }

        public Violin(int numberOfStrings)
        {
            name = "Violin";
            this.numberOfStrings = numberOfStrings;
        }
    }
}
