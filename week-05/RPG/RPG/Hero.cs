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
                try
                {
                    if (MapStructure[Position[1] + 1, Position[0]] == 0)
                    {
                        Position[1] += 1;
                        FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-down.png", UriKind.Relative));
                        foxDraw.SetPosition(FoxDraw.Hero[0], Position[0] * 50, Position[1] * 50);
                        //foxDraw.SetPosition(FoxDraw.Hero[0], Position[0] * 50, Position[1] * 10);
                        //foxDraw.SetPosition(FoxDraw.Hero[0], Position[0] * 50, Position[1] * 10);
                        //foxDraw.SetPosition(FoxDraw.Hero[0], Position[0] * 50, Position[1] * 10);
                        //foxDraw.SetPosition(FoxDraw.Hero[0], Position[0] * 50, Position[1] * 10);
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
                        Position[1] -= 1;
                        FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-up.png", UriKind.Relative));
                        foxDraw.SetPosition(FoxDraw.Hero[0], Position[0] * 50, Position[1] * 50);
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
                        Position[0] += 1;
                        FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-right.png", UriKind.Relative));
                        foxDraw.SetPosition(FoxDraw.Hero[0], Position[0] * 50, Position[1] * 50);
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
                        Position[0] -= 1;
                        FoxDraw.Hero[0].Source = new BitmapImage(new Uri(@".\Assets\hero-left.png", UriKind.Relative));
                        foxDraw.SetPosition(FoxDraw.Hero[0], Position[0] * 50, Position[1] * 50);
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
    }
}
