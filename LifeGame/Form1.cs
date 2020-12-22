using LifeGame.Grapfics;
using LifeGame.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeGame
{
    public partial class Form1 : Form
    {
        Grid _Grid;
        Graphics g;
        Bitmap bmp;
        int Iteration;
        public Form1()
        {
            InitializeComponent();

            _Grid = new Grid(pictureBox1.Width, pictureBox1.Height);
            numericUpDown1.Value = Settings.Settings.GridSeedCount;
            RefreshSetting();
            _Grid.Seed();
            Iteration = 0;
            trackBar1.Value = timer1.Interval;
            speed.Text = trackBar1.Value.ToString();

        }

        private void RefreshSetting()
        {
            pictureBox1.BackColor = tableBackColor.BackColor;
            Settings.Settings.CellColor = new SolidBrush(cellColor.BackColor);
            Settings.Settings.GridColor = new Pen(gridColor.BackColor);
            Settings.Settings.GridSeedCount = (int)numericUpDown1.Value;
            _Grid.RefreshSettings();
        }

        private void Refresh()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);

            //_Grid.DrawGrid(g);
            _Grid.DrawCell(g);
            _Grid.NextIteration();
            pictureBox1.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            iteration.Text = Iteration.ToString();
            Iteration++;
            Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Iteration = 0;
            _Grid = new Grid(pictureBox1.Width, pictureBox1.Height);
            Settings.Settings.GridSeedCount = (int)numericUpDown1.Value;
            _Grid.Seed();
        }

        private void tableBackColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ((PictureBox)sender).BackColor = colorDialog1.Color;
            }
            RefreshSetting();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            speed.Text = trackBar1.Value.ToString();
        }
    }
}
