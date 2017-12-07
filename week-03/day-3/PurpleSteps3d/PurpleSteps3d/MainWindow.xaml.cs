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

namespace PurpleSteps3d
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
            for (int i = 0; i < 6; i++)
            {
                DrawSquare(foxDraw, (i* (i + 1)) /2 * 10 + 10, (i + 1) * 10);
            }
        }
        static void DrawSquare(FoxDraw foxDraw, double position, double size)
        {
            foxDraw.FillColor(Colors.Purple);
            foxDraw.DrawRectangle(position, position, size, size);
        }
    }
}