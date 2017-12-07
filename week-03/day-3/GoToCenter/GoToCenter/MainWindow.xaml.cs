using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace GoToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.
            DrawLineToCenter(foxDraw, 123, 35);
        }
        public static void DrawLineToCenter(FoxDraw foxDraw, double startX, double startY)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(startX, startY, 154, 165);
        }
    }
}
