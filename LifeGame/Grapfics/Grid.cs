using LifeGame.Model;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace LifeGame.Grapfics
{
    class Grid
    {
        public int SHIFT = Settings.Settings.GridShift;

        public Pen GridPen = Settings.Settings.GridColor;
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int MatrixWidth { get; private set; }
        public int MatrixHeight { get; private set; }

        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
            MatrixWidth = Width / SHIFT;
            MatrixHeight = Height / SHIFT;
            Cell.Cells = new Dictionary<string, Cell>();
        }

        public void RefreshSettings()
        {
            SHIFT = Settings.Settings.GridShift;
            GridPen = Settings.Settings.GridColor;
        }

        public void Seed()
        {
            Random rand = new Random();
            int i = 0;
            while (i < Settings.Settings.GridSeedCount)
            {
                int x = rand.Next(0, MatrixWidth);
                int y = rand.Next(0, MatrixHeight);
                string key = Keys.ConvertToKey(new Point(x, y));
                if (!Cell.Cells.ContainsKey(key))
                {
                    Cell cell = new Cell(x, y);
                }
                i++;
            }
        }

        public void NextIteration()
        {
            for (int y = 0; y < MatrixHeight; y++)
            {
                for (int x = 0; x < MatrixWidth; x++)
                {
                    CellBornOrDie.IterationProcess(x, y);
                }
            }


        }

        public void DrawGrid(Graphics g)
        {
            int x = 0, y = 0;
            while(x < Width)
            {
                g.DrawLine(GridPen, new Point(x, 0), new Point(x, Height));
                x += SHIFT;
            }

            while (y < Height)
            {
                g.DrawLine(GridPen, new Point(0, y), new Point(Width, y));
                y += SHIFT;
            }
        }

        public void DrawCell(Graphics g)
        {
            foreach (var item in Cell.Cells)
            {
                item.Value.Draw(g, SHIFT);
            }
        }
    }
}
