using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplications.Blokus
{
    public partial class PieceSelectControl : UserControl
    {
        private List<PieceControl> tiles = new List<PieceControl>(21);
        public Player player;
        public PieceSelectControl()
        {
            InitializeComponent();
            this.player = new Player();
        }
        public PieceSelectControl(Player p)
            : this()
        {
            this.player = p;
        }
        protected override void OnLoad(EventArgs e)
        {
            List<PieceControl> controls = new List<PieceControl>(this.player.piecesLeft);
            int row = 0;
            int col = 0;

            for (int i = 0; i < controls.Capacity; i++, col++)
            {
                Tile piece = (Tile)player.hand[i];
                controls.Add(new PieceControl(piece));
                /*
                int xPoint = (col) * 80 + 15;
                // Horizontally center the pieces
                xPoint += (5 - piece.width) * 5;
                
                int yPoint = (row) * 50 + 10 * (3 - piece.height);
                // Vertically center the pieces
                yPoint += -(1 - piece.height) * 5;
                /**/
                int xPoint = (col) * 80;
                int yPoint = (row) * 50;
                controls[i].Location = new System.Drawing.Point(xPoint, yPoint);
                
                
                if (col > 3) // avoiding a nested for loop
                {
                    row++;
                    col = -1;
                }
                controls[i].Name = "myControl" + (2 + i);
                controls[i].player = this.player;
                controls[i].Size = new Size(80, 50);
//                controls[i].Size = new System.Drawing.Size(51, 51);
//                controls[i].fit();
                controls[i].TabIndex = i + 1;
                controls[i].SendToBack();

                this.Controls.Add(controls[i]);
            }
            this.tiles = controls;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            /*
            Pen r = new Pen(Color.Red);
            for (int x2 = 0; x2 < this.Width; x2 += 10)
            {
                g.DrawLine(r, x2, 0, x2, this.Height);
            }
            for (int y2 = 0; y2 < this.Height; y2 += 10)
            {
                g.DrawLine(r, 0, y2, this.Width, y2);
            }
            */
            Pen p = new Pen(Color.Black);
            for (int x = 0; x < this.Width; x += 80)
            {
                g.DrawLine(p, x, 0, x, this.Height);
            }
            for (int y = 0; y < this.Height; y += 50)
            {
                g.DrawLine(p, 0, y, this.Width, y);
            }
            foreach (PieceControl pctrl in tiles)
            {
                pctrl.player = this.player;
                pctrl.Refresh();
            }
            
        }

        private void PieceSelectControl_MouseClick(object sender, MouseEventArgs e)
        {
            double x = e.X;
            double y = e.Y;
            int width = this.Width;
            int height = this.Height;
            bool inXBounds = x >= 0 && x <= width;
            bool inYBounds = y >= 0 && y <= height;
            if (inXBounds && inYBounds)
            {
                Console.WriteLine("{0} {1}", Math.Floor(x / 80.0), Math.Floor(y / 50.0));
            }
        }



    }
}
