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
        }
        public SelectionControl(CurrentPlayer p)
            : this()
        {
            this.player = p;
        }

        public void setup(CurrentPlayer player)
        {
            this.player = player;
            List<PieceControl> controls;
            int row = 0;
            int col = 0;

            controls = new List<PieceControl>(21);
            for (int i = 0; i < controls.Capacity && i < player.piecesLeft; i++, col++)
            {
                Tile piece = (Tile)player.hand[i];
                //                if (!piece.Equals(new Tile()))
                controls.Add(new PieceControl(player, piece));
                int xPoint = (col) * this.Width / 5;
                int yPoint = (row) * this.Height / 4;
                controls[i].Location = new System.Drawing.Point(xPoint, yPoint);
                controls[i].setup(this.player);
                controls[i].Size = new Size(80, 62);

                if (col > 3) // avoiding a nested for loop
                {
                    row++;
                    col = -1;
                }

                this.Controls.Add(controls[i]);

            }
            this.tiles = controls;

        }

        public void redraw()
        {
            if (tiles.Count == 0)
            {
                setup(this.player);
            }
            // Draw the contents of the control based on the tiles in the current player's hand
            for (int i = 0; i < tiles.Count; i++)
            {
                tiles[i].setup(this.player);
                tiles[i].piece = (Tile)player.hand[i];
                tiles[i].Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            redraw();
        }

        public void load()
        {
            List<PieceControl> controls;
            int row = 0;
            int col = 0;

            controls = new List<PieceControl>(21);
            for (int i = 0; i < controls.Capacity; i++, col++)
            {
                Tile piece = (Tile)player.hand[i];
                //                if (!piece.Equals(new Tile()))
                controls.Add(new PieceControl(player, piece));
                int xPoint = (col) * this.Width / 5;
                int yPoint = (row) * this.Height / 4;
                controls[i].Location = new System.Drawing.Point(xPoint, yPoint);
                controls[i].setup(this.player);
                controls[i].Size = new Size(80, 60);

                if (col > 3) // avoiding a nested for loop
                {
                    row++;
                    col = -1;
                }

                this.Controls.Add(controls[i]);

            }
            this.tiles = controls;
        }


    }
}
