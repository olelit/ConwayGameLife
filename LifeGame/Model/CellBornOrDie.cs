using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame.Model
{
    public static class CellBornOrDie
    {
        public static Point[] GetMatrixNear(Point position)
        {
            Point[] search = { 
                new Point(position.X - 1, position.Y - 1),
                new Point(position.X, position.Y - 1),
                new Point(position.X + 1, position.Y - 1),
                new Point(position.X - 1, position.Y),
                new Point(position.X + 1, position.Y),
                new Point(position.X - 1, position.Y + 1),
                new Point(position.X, position.Y + 1),
                new Point(position.X + 1, position.Y + 1)
            };
            return search;
        }

        public static void IterationProcess(int x, int y)
        {
            int sum = 0;
            
            Cell current = Cell.GetCellByCoord(new Point(x, y));
            foreach (Point point in GetMatrixNear(new Point(x, y)))
            {
                Cell cell = Cell.GetCellByCoord(point);
                if (cell != null)
                {
                    sum += 1;
                }
            }
            
            if(current == null && sum == 3)
            {
                new Cell(x, y);
            }

            if(current != null && (sum != 2 && sum != 3))
            {
                current.Delete();
            }

        }

    }
}
