using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace Diagonals
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw the canvas' diagonals in green.
            DrawLine(foxDraw, 0, 0, Width, Height, Colors.Green);
            DrawLine(foxDraw, 0, Height, Width, 0, Colors.Green);
        }
        public static void DrawLine(FoxDraw foxDraw, double startX, double startY, double endX, double endY, Color color)
        {
            foxDraw.StrokeColor(color);
            foxDraw.DrawLine(startX, startY, endX, endY);
        }
    }
}