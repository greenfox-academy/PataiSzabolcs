using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows.Input;

namespace RPG
{
    class Hero : Character
    {
        public Hero (FoxDraw foxDraw, int[,] mapstructure)
        {
            Position[0] = 0;
            Position[1] = 0;
            MapStructure = mapstructure;
            FoxDraw = foxDraw;
            foxDraw.AddHero(@".\Assets\hero-down.png", Position[0], Position[1]);
        }

        public void Move(FoxDraw foxDraw, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                if (MapStructure[Position[1] + 1, Position[0]] == 0)
                {
                    Position[1] += 1;
                }
            }
            if (e.Key == Key.Up)
            {
                if (MapStructure[Position[1] - 1, Position[0]] == 0)
                {
                    Position[1] -= 1;
                }
            }
            if (e.Key == Key.Right)
            {
                if (MapStructure[Position[1], Position[0] + 1] == 0)
                {
                    Position[0] += 1;
                }
            }
            if (e.Key == Key.Left)
            {
                if (MapStructure[Position[1], Position[0] - 1] == 0)
                {
                    Position[0] -= 1;
                }
            }
            foxDraw.SetPosition(FoxDraw.Hero[0], Position[0] * 50, Position[1] * 50);
        }
    }
}
