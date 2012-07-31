using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplications.Blokus
{
    public partial class SelectionControl : UserControl
    {
        public List<PieceControl> tiles = new List<PieceControl>();
        public CurrentPlayer player;

        public SelectionControl()
        {
            InitializeComponent();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer, true);
            this.player = new CurrentPlayer();
        }
        public SelectionControl(CurrentPlayer p)
            : this()
        {
            this.player = p;
        }

        public void setup()
        {
            // TODO: Implement
        }

        public void Reload(CurrentPlayer p, EventArgs e)
        {
            this.player = p;
            OnLoad(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            List<PieceControl> controls = new List<PieceControl>(21);
            int row = 0;
            int col = 0;

            for (int i = 0; i < controls.Capacity && i < this.player.piecesLeft; i++, col++)
            {
                Tile piece = (Tile)player.hand[i];
//                if (!piece.Equals(new Tile()))
                    controls.Add(new PieceControl(piece));
//                    Console.WriteLine("New Player");
                int xPoint = (col) * this.Width / 5;
                int yPoint = (row) * this.Height / 4;
                controls[i].Location = new System.Drawing.Point(xPoint, yPoint);
                controls[i].player = this.player;
                controls[i].Size = new Size(80, 61);

                if (col > 3) // avoiding a nested for loop
                {
                    row++;
                    col = -1;
                }

                this.Controls.Add(controls[i]);

            }
            this.tiles = controls;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw the contents of the control based on the tiles in the current player's hand
            for (int i = 0; i < player.piecesLeft; i++)
            {
                tiles[i].player = this.player;
                tiles[i].piece = (Tile)player.hand[i];
                tiles[i].Refresh();
            }
        }

        private void printer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < player.hand.Count; i++)
            {
                Tile t1 = tiles[i].piece, t2 = (Tile)player.hand[i];
                if (!t1.Equals(t2))
                {
                    Console.WriteLine("Control:\n"+t1);
                Console.WriteLine("Hand:\n"+t2);
                }
            }
            Console.WriteLine("----");
        }
    }
}
