using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System;
using System.Windows;
using GreenFox;

namespace RainbowBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.

            Color[] color = { Colors.Violet, Colors.Indigo, Colors.Blue, Colors.Green, Colors.Yellow, Colors.Orange, Colors.Red };
            for (int i = 6; i > -1; i--)
            {
                DrawCenterSquare(foxDraw, 400 / 7 * i + 400 / 7, color[i]);
            }

        }
        static void DrawCenterSquare(FoxDraw foxDraw, double size, Color color)
        {
            foxDraw.FillColor(color);
            foxDraw.DrawRectangle((400 - size) / 2, (400 - size) / 2, size, size);
        }
    }
}