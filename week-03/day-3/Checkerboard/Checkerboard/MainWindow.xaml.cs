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
using GreenFox;

namespace Checkerboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Color[] color = { Colors.White, Colors.Black };
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    DrawSquare(foxDraw, j * 50, i * 50, color[(i+ j + 2) % 2]);
                }
            }
        }
        static void DrawSquare(FoxDraw foxDraw, double x, double y, Color color)
        {
            foxDraw.StrokeColor(color);
            foxDraw.FillColor(color);
            foxDraw.DrawRectangle(x, y, 50, 50);
        }
    }
}