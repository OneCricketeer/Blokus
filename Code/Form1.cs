using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApplications.Blokus
{
    public partial class Form1 : Form
    {
        private Player p = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<PieceControl> controls = new List<PieceControl>(21);
            int row = 0;
            int col = 0;

            for (int i = 0; i < controls.Capacity; i++, col++)
            {
                Tile piece = (Tile)p.hand[i];
                controls.Add(new PieceControl(piece));
                int xPoint = (col) * 80 + 15;
                int yPoint = (row) * 50 +10*(3-piece.height);
                if (piece.height == 3) yPoint += 10;
                controls[i].Location = new System.Drawing.Point(xPoint, yPoint);
                if (col > 3)
                {
                    row++;
                    col = -1;
                }
                controls[i].Name = "myControl" + (2 + i);
                controls[i].Size = new System.Drawing.Size(51, 51);
                controls[i].fit();
                controls[i].TabIndex = i + 1;
                controls[i].SendToBack();

                this.Controls.Add(controls[i]);
            }
        }
//        protected override void OnPaint(PaintEventArgs e)
//        {
//            Graphics g = e.Graphics;
//            Pen p = new Pen(Color.Black);
//            for (double x = this.Left; x < this.Right; x+=80)
//            {
//                g.DrawLine(p, (int)x, this.Top, (int)x, this.Bottom);
//            }
//        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);
            for (double x = 0; x < this.Width; x += 80)
            {
                g.DrawLine(p, (int)x, 0, (int)x, this.Height);
            }
            for (int y = 0; y < this.Height; y+=50)
            {
                g.DrawLine(p, 0, y, this.Width, y);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            double x = e.X;
            double y = e.Y;
            int width = 400;
            int height = 230;
            bool inXBounds = x >= 0 && x <= width;
            bool inYBounds = y >= 0 && y <= height;
            if (inXBounds && inYBounds)
            {
                Console.WriteLine("{0} {1}", Math.Floor(x/80.0), Math.Floor(y/50.0));
            }
        }
    }
}
