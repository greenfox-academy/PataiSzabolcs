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
        private int[,] MapStructure;
        private int[] HeroPosition;
        private List<int[]> EnemyPosition;

        public MainWindow()
        {
            InitializeComponent();
            
            StartGame();
            
            
        }

        public void StartGame()
        {
            SetUpMap();
            EnemyPosition = new List<int[]>();
            HeroPosition = new int[2];
            SetUpCharacters(EnemyPosition, HeroPosition);
            SetUpHUD();
        }

        public void SetUpCharacters(List<int[]> EnemyPosition, int[] HeroPosition)
        {
            FoxDraw foxDraw = new FoxDraw(canvas);
            Hero = new Hero(FoxDraw, MapStructure);
            List<Enemy> skeletons = new List<Enemy>();
            Random random = new Random();            
            for (int i = 0; i < 3; i++)
            {
                int[] skeletonPosition = new int[] { random.Next(0, 10), random.Next(0, 10) };
                while (!IsFloor(skeletonPosition))
                {
                    skeletonPosition[0] = random.Next(0, 10);
                    skeletonPosition[1] = random.Next(0, 10);
                }
                Enemy skeleton = new Enemy(FoxDraw, MapStructure, skeletonPosition, "skeleton");
                EnemyPosition.Add(skeleton.Position);
                skeletons.Add(skeleton);
            }
            int[] bossPosition = new int[] { random.Next(0, 10), random.Next(0, 10) };
            while (!IsFloor(bossPosition))
            {
                bossPosition[0] = random.Next(0, 10);
                bossPosition[1] = random.Next(0, 10);
            }            
            Enemy boss = new Enemy(FoxDraw, MapStructure, bossPosition, "boss");
            EnemyPosition.Add(boss.Position);

        }

        public bool IsFloor(int[] position)
        {
            return MapStructure[position[1], position[0]] == 0;
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

        public void SetUpHUD()
        {
            HUD.Text = "Hero (Level 1) HP: 8/10 | DP: 8 | SP: 6";
        }

        public void KeyDownEvent(object sender, KeyEventArgs e)
        {
            FoxDraw = new FoxDraw(canvas);
            Hero.MoveHero(FoxDraw, e);
        }
    }
}
