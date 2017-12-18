using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG
{
    class Character
    {
        public int[] Position = new int[] {0, 0 };
        public FoxDraw FoxDraw { get; set; }
        public int[,] MapStructure { get; set; }
    }
}
