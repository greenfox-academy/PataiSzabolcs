using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace LineInTheMiddle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.
            DrawLine(foxDraw, 0, Height / 2, 338, Height / 2, Colors.Red);
            DrawLine(foxDraw, Width / 2, 0, Width / 2, 308, Colors.Green);

        }
        public static void DrawLine(FoxDraw foxDraw, double startX, double startY, double endX, double endY, Color color)
        {
            foxDraw.StrokeColor(color);
            foxDraw.DrawLine(startX, startY, endX, endY);
        }
    }
}