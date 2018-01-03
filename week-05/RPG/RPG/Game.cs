using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG
{
    class Game
    {
        private FoxDraw foxDraw;
        public int[,] MapStructure { get; set; }

        // create map
        // create characters
        // key events
        // fight method


        List<Character> list = new List<Character>();
        Hero hero = new Hero(foxDraw, MapStructure);
        List<Enemy> skeletons = new List<Enemy>();
        Random random = new Random();            
            for (int i = 0; i< 3; i++)
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
}
