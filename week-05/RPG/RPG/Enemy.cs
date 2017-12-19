using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace RPG
{
    class Enemy : Character
    {
        public Enemy(FoxDraw foxDraw, int[,] mapstructure, int[] position, string type) : base(foxDraw, mapstructure)
        {
            Position[0] = position[0] * 50;
            Position[1] = position[1] * 50;
            if (type == "boss")
            {
                foxDraw.AddEnemy(@".\Assets\boss.png", Position[0], Position[1]);
            }
            else
            {
                foxDraw.AddEnemy(@".\Assets\skeleton.png", Position[0], Position[1]);
            }
        }
    }
}
