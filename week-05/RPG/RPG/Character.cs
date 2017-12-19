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
        public int[] Position = new int[] { 0, 0 };
        public FoxDraw FoxDraw { get; set; }
        public static int[,] MapStructure { get; set; }

        public Character (FoxDraw foxDraw, int[,] mapstructure)
        {
            MapStructure = mapstructure;
            FoxDraw = foxDraw;
        }
        
        public static bool IsFloor(int[] position)
        {
            return MapStructure[position[1], position[0]] == 0;
        }
        //public void SetPosition(int[] position)
        //{
        //    Position[0] = position[0] * 50;
        //    Position[1] = position[1] * 50;
        //}
    }

}
