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
    class Hero : Character
    {
        public Hero(FoxDraw foxDraw, int[,] mapStructure) : base(foxDraw, mapStructure)
        {
            Position[0] = 0;
            Position[1] = 0;
            foxDraw.AddHero(@".\Assets\hero-down.png", Position[0], Position[1]);
            HealthPoint = 20 + random.Next(1, 7);
            DefensePoint = 2 + random.Next(1, 7);
            StrikePoint = 5 + random.Next(1, 7);
        }

        public void MoveHero(FoxDraw foxDraw, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                try
                {
                    if (GetMapElement("Down") == 0)
                    {
                        MoveTo(foxDraw, "Down");
                    }
                    if (MapStructure[Position[1] + 1, Position[0]] == 3)
                    {
                        MapStructure[Position[1], Position[0]] = 0;
                        Position[1] += 1;
                        FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-down.png", UriKind.Relative));
                        foxDraw.SetPosition(FoxDraw.Hero[0], Position[0] * 50, Position[1] * 50);
                        //Fight();
                    }
                    else
                    {
                        FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-down.png", UriKind.Relative));
                    }
                }
                catch (Exception)
                {
                    FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-down.png", UriKind.Relative));
                }
            }
            if (e.Key == Key.Up)
            {
                try
                {
                    if (MapStructure[Position[1] - 1, Position[0]] == 0)
                    {
                        MoveTo(foxDraw, "Up");
                    }
                    else
                    {
                        FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-up.png", UriKind.Relative));
                    }
                }
                catch (Exception)
                {
                    FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-up.png", UriKind.Relative));
                }
            }
            if (e.Key == Key.Right)
            {
                try
                {
                    if (MapStructure[Position[1], Position[0] + 1] == 0)
                    {
                        MoveTo(foxDraw, "Right");
                    }
                    else
                    {
                        FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-right.png", UriKind.Relative));
                    }
                }
                catch (Exception)
                {
                    FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-right.png", UriKind.Relative));
                }
            }
            if (e.Key == Key.Left)
            {
                try
                {
                    if (MapStructure[Position[1], Position[0] - 1] == 0)
                    {
                        MoveTo(foxDraw, "Left");
                    }
                    else
                    {
                        FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-left.png", UriKind.Relative));
                    }
                }
                catch (Exception)
                {
                    FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-left.png", UriKind.Relative));
                }
            }
        }

        public void MoveTo(FoxDraw foxDraw, string direction)
        {
            MapStructure[Position[1], Position[0]] = 0;
            if (direction == "down" || direction == "D" || direction == "d" || direction == "Down")
            {
                Position[1] += 1;
            }
            if (direction == "up" || direction == "U" || direction == "u" || direction == "Up")
            {
                Position[1] -= 1;
            }
            if (direction == "right" || direction == "R" || direction == "r" || direction == "Right")
            {
                Position[0] += 1;
            }
            if (direction == "left" || direction == "L" || direction == "l" || direction == "Left")
            {
                Position[0] -= 1;
            }
            MapStructure[Position[1], Position[0]] = 2;
            FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-down.png", UriKind.Relative));
            foxDraw.SetPosition(FoxDraw.Hero[0], Position[0] * 50, Position[1] * 50);
        }

        public int GetMapElement(string direction)
        {
            if (direction == "down" || direction == "D" || direction == "d" || direction == "Down")
            {
                return MapStructure[Position[1] + 1, Position[0]];
            }
            if (direction == "up" || direction == "U" || direction == "u" || direction == "Up")
            {
                return MapStructure[Position[1] - 1, Position[0]];
            }
            if (direction == "right" || direction == "R" || direction == "r" || direction == "Right")
            {
                return MapStructure[Position[1], Position[0] + 1];
            }
            if (direction == "left" || direction == "L" || direction == "l" || direction == "Left")
            {
                return MapStructure[Position[1], Position[0] - 1];
            }
            else
            {
                return MapStructure[Position[1], Position[0]];
            }
        }
    }
}
