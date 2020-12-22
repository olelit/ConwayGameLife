using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame.Model
{
    class Cell
    {
        public static Dictionary<string, Cell> Cells = new Dictionary<string, Cell>();

        public Point Position{ get; private set; }

        public SolidBrush _Color = Settings.Settings.CellColor;

        public string Key => Keys.ConvertToKey(Position);

        public Cell(int x, int y)
        {
            Position = new Point(x, y);
            Cells.Add(Key, this);
        }
        public void Delete()
        {
            Cells.Remove(Key);
        }

        public void Draw(Graphics g, int shift)
        {
            int transX = Position.X * shift;
            int transY = Position.Y * shift;
            Point start = new Point(transX, transY);
            g.FillEllipse(_Color, new Rectangle(start, new Size(shift, shift)));
        }

        public static Cell GetCellByCoord(Point point)
        {
            string key = Keys.ConvertToKey(point);
            if(Cells.ContainsKey(key))
                return Cells[key];
            return null;
        }

    }
}
