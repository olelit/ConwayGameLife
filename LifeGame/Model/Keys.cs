using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame.Model
{
    public static class Keys
    {
        public static string ConvertToKey(Point point)
        {
            return point.X.ToString() +"_"+ point.Y.ToString();
        }
    }
}
