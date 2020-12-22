using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame.Settings
{
    public class Settings
    {
        //GridSettings
        public static int GridShift = 4;
        public static Pen GridColor = new Pen(Color.Black);
        public static int GridSeedCount = 1000;

        //Cell
        public static SolidBrush CellColor = new SolidBrush(Color.Gray);
    }
}
