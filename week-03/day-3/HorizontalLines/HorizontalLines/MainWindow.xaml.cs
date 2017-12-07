using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace HorizontalLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // draw 3 lines with that function.
            DrawHorizontalLine(foxDraw, 15, 36);
            DrawHorizontalLine(foxDraw, 165, 100);
            DrawHorizontalLine(foxDraw, 88, 2);

        }
        public static void DrawHorizontalLine(FoxDraw foxDraw, double startX, double startY)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(startX, startY, startX + 50, startY);
        }
    }
}