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

namespace RPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpMap();

        }

        public void SetUpMap()
        {
            FoxDraw foxDraw = new FoxDraw(canvas);
            int[,] mapStructure = new int[11, 10]
            {
                { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 1, 0, 1, 1, 0 },
                { 0, 1, 1, 1, 0, 1, 0, 1, 1, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0 },
                { 0, 1, 0, 1, 0, 0, 0, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 1, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 1, 1, 0, 1, 0 },
                { 0, 1, 1, 1, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 1, 0, 1, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0 }
            };

            Map map = new Map(foxDraw, mapStructure);
            map.DrawMap();            
        }

        public void AddTile()
        {
            FoxDraw foxDraw = new FoxDraw(canvas);
            foxDraw.AddImage(@".\Assets\boss.png", 20, 20);

        }
    }
}
