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

namespace LinePlay
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
            for (int i = 0; i < 18; i++)
            {
                DrawLine(foxDraw, 0, (i + 1) * 20, Colors.Green);
            }
            for (int i = 0; i < 18; i++)
            {
                DrawLine(foxDraw, 400, 400 - (i + 1) * 20, Colors.Purple);
            }
        }
        static void DrawLine(FoxDraw foxDraw, double x, double y, Color color)
        {
            foxDraw.StrokeColor(color);
            foxDraw.DrawLine(x + 5, y + 5, y + 5, (x - 400) * -1 + 5);
        }
    }
}
