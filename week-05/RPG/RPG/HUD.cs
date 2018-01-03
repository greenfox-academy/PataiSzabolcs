using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RPG
{
    class HUD
    {
        public FoxDraw FoxDraw { get; set; }

        public HUD (FoxDraw foxDraw)
        {
            TextBlock HUD = new TextBlock();
            //FoxDraw = foxDraw;
            //FoxDraw.FillColor(Colors.White);

            //FoxDraw.DrawRectangle(0, 500, 500, 50);
        }
    }
}
