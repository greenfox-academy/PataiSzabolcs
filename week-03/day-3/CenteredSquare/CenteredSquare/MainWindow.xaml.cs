using System;
using System.Windows;
using GreenFox;

namespace CenteredSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a green 10x10 square to the canvas' center.
            DrawRectangle(foxDraw);
        }
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            foxDraw.DrawRectangle(160, 149, 10, 10);
        }
    }
}