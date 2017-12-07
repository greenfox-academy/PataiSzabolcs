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

namespace Graphic
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

            DrawCross(foxDraw, 0, 0, 600, 3);
        }
        static void DrawCross(FoxDraw foxDraw, double startingx, double startingy, double size, int levels)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.White);
            if (levels == 1)
            {
                foxDraw.DrawRectangle(startingx + (size / 3), startingy, size / 3, size / 3);
                foxDraw.DrawRectangle(startingx, startingy + (size / 3), size / 3, size / 3);
                foxDraw.DrawRectangle(startingx + ((size / 3) * 2), startingy + (size / 3), size / 3, size / 3);
                foxDraw.DrawRectangle(startingx + (size / 3), startingy + ((size / 3) * 2), size / 3, size / 3);

            }
            else
            {
                DrawCross(foxDraw, startingx + (size / 3), startingy, size / 3, levels-1);
                DrawCross(foxDraw, startingx, startingy + (size / 3), size / 3, levels -1);
                DrawCross(foxDraw, startingx + ((size / 3) * 2), startingy + (size / 3), size / 3, levels -1);
                DrawCross(foxDraw, startingx + (size / 3), startingy + ((size / 3) * 2), size / 3, levels -1);
            }
        }

    }
}
