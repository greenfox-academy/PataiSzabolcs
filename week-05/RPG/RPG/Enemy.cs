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
                HealthPoint = 20 + random.Next(1, 7);
                DefensePoint = 2 + random.Next(1, 7);
                StrikePoint = 5 + random.Next(1, 7);
            }
            else
            {
                foxDraw.AddEnemy(@".\Assets\skeleton.png", Position[0], Position[1]);
                HealthPoint = 2 + random.Next(1, 7);
                DefensePoint = 1 + random.Next(1, 7);
                StrikePoint = 1 + random.Next(1, 7);
            }
        }
    }
}
