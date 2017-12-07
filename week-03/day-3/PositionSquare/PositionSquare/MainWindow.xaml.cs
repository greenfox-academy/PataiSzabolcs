using System;
using System.Windows;
using GreenFox;
using System.Media;

namespace PositionSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.

            for (int i = 0; i < 3; i++)
            {
                DrawSquare(foxDraw, 10, 10 + i * 55);
            }

        }
        static void DrawSquare(FoxDraw foxDraw, double x, double y)
        {
            foxDraw.DrawRectangle(x, y, 50, 50);
        }
    }
}