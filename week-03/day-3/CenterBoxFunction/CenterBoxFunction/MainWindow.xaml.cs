using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace CenterBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.

            DrawCenterSquare(foxDraw, 70);
            DrawCenterSquare(foxDraw, 60);
            DrawCenterSquare(foxDraw,50);
        }
        static void DrawCenterSquare(FoxDraw foxDraw, double size)
        {
            foxDraw.DrawRectangle((308 - size) / 2, (331-size) /2, size, size);
        }
    }
}