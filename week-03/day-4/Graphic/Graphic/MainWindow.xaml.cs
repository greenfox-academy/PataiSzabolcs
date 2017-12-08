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

            DrawCross(foxDraw, 0, 0, 600, 6);
        }
        static void DrawCross(FoxDraw foxDraw, double startingX, double startingY, double size, int levels)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.Yellow);
            if (levels == 0)
            {
                return;
            }
            foxDraw.DrawRectangle(startingX, startingY, size, size);
            
                DrawCross(foxDraw, startingX + (size / 3), startingY, size / 3, levels-1);
                DrawCross(foxDraw, startingX, startingY + (size / 3), size / 3, levels -1);
                DrawCross(foxDraw, startingX + ((size / 3) * 2), startingY + (size / 3), size / 3, levels -1);
                DrawCross(foxDraw, startingX + (size / 3), startingY + ((size / 3) * 2), size / 3, levels -1);            
        }

    }
}
