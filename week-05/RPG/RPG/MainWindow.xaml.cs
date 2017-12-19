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
        private FoxDraw FoxDraw;
        private Hero Hero;
        private Enemy Enemy;
        private int[,] MapStructure;
        

        public MainWindow()
        {
            InitializeComponent();
            SetUpMap();
            SetUpCharacters();
        }

        public void SetUpCharacters()
        {
            FoxDraw foxDraw = new FoxDraw(canvas);
            Hero = new Hero(FoxDraw, MapStructure);
            List<Enemy> skeletons = new List<Enemy>();
            Random random = new Random();            
            for (int i = 0; i < 3; i++)
            {
                int[] skeletonPosition = new int[] { random.Next(0, 10), random.Next(0, 10) };
                while (!Character.IsFloor(skeletonPosition))
                {
                    skeletonPosition[0] = random.Next(0, 10);
                    skeletonPosition[1] = random.Next(0, 10);
                }
                Enemy skeleton = new Enemy(FoxDraw, MapStructure, skeletonPosition, "skeleton");
                skeletons.Add(skeleton);
            }
            int[] bossPosition = new int[] { random.Next(0, 10), random.Next(0, 10) };
            while (!Character.IsFloor(bossPosition))
            {
                bossPosition[0] = random.Next(0, 10);
                bossPosition[1] = random.Next(0, 10);
            }
            Enemy boss = new Enemy(FoxDraw, MapStructure, bossPosition, "boss");
        }

        public void SetUpMap()
        {
            FoxDraw = new FoxDraw(canvas);
            MapStructure = new int[10, 10]
            {
                { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 1, 0, 1, 1, 0 },
                { 0, 1, 1, 1, 0, 1, 0, 1, 1, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0 },
                { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 1, 0, 1, 1, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 1, 1, 0, 1, 0 },
                { 0, 1, 1, 1, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 1, 0, 1, 1, 0, 1, 0 }
            };

            Map map = new Map(FoxDraw, MapStructure);
            map.DrawMap();            
        }

        public void KeyDownEvent(object sender, KeyEventArgs e)
        {
            FoxDraw = new FoxDraw(canvas);
            Hero.Move(FoxDraw, e);
        }
    }
}
