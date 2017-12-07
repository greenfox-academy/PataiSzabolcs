using System;
using System.Windows;
using GreenFox;
using System.Collections.Generic;
using System.Windows.Media;

namespace ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a box that has different colored lines on each edge.
            DrawLine(foxDraw, 10, 10, 200, 10, Colors.Red);
            DrawLine(foxDraw, 200, 10, 200, 200, Colors.DimGray);
            DrawLine(foxDraw, 200, 200, 10, 200, Colors.Orange);
            DrawLine(foxDraw, 10, 200, 10, 10, Colors.Tan);
        }
        public static void DrawLine(FoxDraw foxDraw, double startX, double startY, double endX, double endY, Color color)
        {
            foxDraw.StrokeColor(color);
            foxDraw.DrawLine(startX, startY, endX, endY);
        }
    }
}