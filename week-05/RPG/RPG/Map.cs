using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using GreenFox;

namespace RPG
{
    public class Map
    {
        public FoxDraw FoxDraw { get; set; }
        private int[,] MapStructure { get; set; }

        public Map (FoxDraw foxDraw, int[,] mapStructure)
        {
            FoxDraw = foxDraw;
            MapStructure = mapStructure;
        }

        public void DrawMap()
        {
            for (int i = 0; i < MapStructure.GetLength(0); i++)
            {
                for (int j = 0; j < MapStructure.GetLength(1); j++)
                {
                    if (MapStructure[i,j] == 1)
                    {
                        CreateWallTile(i, j);
                    }
                    else
                    {
                        CreateFloorTile(i, j);
                    }
                }
            }
        }       

        public void CreateFloorTile(int row, int column)
        {
            FoxDraw.AddTile(@".\Assets\floor.png", column* 50, row * 50);
        }

        public void CreateWallTile(int row, int column)
        {
            FoxDraw.AddTile(@".\Assets\wall.png", column * 50, row * 50);
        }
    }

}
