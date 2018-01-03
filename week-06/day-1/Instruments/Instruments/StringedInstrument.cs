using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        public abstract string Sound();

        public override void Play()
        {
            Console.WriteLine($"{name}, a {numberOfStrings}-stringed instrument that {Sound()}");
        }
    }
}
