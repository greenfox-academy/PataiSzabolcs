using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG
{
    class Character : Map
    {
        public int[] Position = new int[] { 0, 0 };
        public int HealthPoint { get; set; }
        public int DefensePoint { get; set; }
        public int StrikePoint { get; set; }
        public Random random = new Random();

        public Character (FoxDraw foxDraw, int[,] mapStructure) : base(foxDraw, mapStructure)
        {
            MapStructure = mapStructure;
            FoxDraw = foxDraw;
        }
        
        
        //public void SetPosition(int[] position)
        //{
        //    Position[0] = position[0] * 50;
        //    Position[1] = position[1] * 50;
        //}
    }

}
