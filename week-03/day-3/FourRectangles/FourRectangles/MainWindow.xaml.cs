using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw four different size and color rectangles.
            DrawRectangle(foxDraw, 10, 10, 100, 100, Colors.Red);
            DrawRectangle(foxDraw, 10, 130, 10, 10, Colors.Green);
            DrawRectangle(foxDraw, 10, 150, 60, 60, Colors.Brown);
            DrawRectangle(foxDraw, 10, 220, 150, 10, Colors.Black);
        }
        public static void DrawRectangle(FoxDraw foxDraw, double x, double y, double width, double height, Color color)
        {
            foxDraw.StrokeColor(color);
            foxDraw.FillColor(color);
            foxDraw.DrawRectangle( x, y, width, height);
        }
    }
}