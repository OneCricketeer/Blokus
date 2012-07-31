using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplications.Blokus
{
    public partial class BoardControl : UserControl
    {
        private const float TILE_SIZE = 20;
        private BoardMatrix matrx;
        public int _colorNum = 0;
        public Color color;
        private CurrentPlayer player;

        public BoardControl()
        {
            InitializeComponent();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer, true);
            matrx = new BoardMatrix((int)TILE_SIZE, (int)TILE_SIZE);
        }

        public void setup()
        {
            // TODO: Implement
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            /* GridLines */
            Pen pen = new Pen(Color.Black);
            Pen borderPen = new Pen(Color.Black, 2);

            for (int x = 0; x < this.Width; x += (int)TILE_SIZE)
            {
                g.DrawLine(pen, x, 0, x, this.Width);
            }
            for (int y = 0; y < this.Height; y += (int)TILE_SIZE)
            {
                g.DrawLine(pen, 0, y, this.Width, y);
            }

            /* Text */
            // StringFormat fmt = new StringFormat();
            // fmt.Alignment = StringAlignment.Center;
            // fmt.LineAlignment = StringAlignment.Center;
            // Font drawFont = new Font("Time New Roman", 12);

            int i = 0;
            int j = 0;
            String tile;

            // Draw
            for (float y = 0; y < this.Height; y += TILE_SIZE, i++)
            {
                j = 0;
                for (float x = 0; x < this.Width; x += TILE_SIZE, j++)
                {
                    try
                    {
                        tile = matrx[i][j].ToString();
                    }
                    catch (Exception) { continue; }

                    if (tile != "0")
                    {
                        this.color = matrx[i][j] == 5 ? Color.White : BlokusGame.colors[matrx[i][j] - 1];
                        RectangleF drawRect = new RectangleF(x, y, TILE_SIZE, TILE_SIZE);
                        Rectangle cell = new Rectangle((int)drawRect.X, (int)drawRect.Y, (int)drawRect.Width, (int)drawRect.Height);
                        e.Graphics.FillRectangle(new SolidBrush(this.color), cell);
                        e.Graphics.DrawRectangle(new Pen(Color.Black, 1), cell);
                        //                        e.Graphics.DrawString(tile, drawFont, new SolidBrush(Color.Black), drawRect, fmt);
                    }
                }
            }

            // Overlap the board with the outer border
            g.DrawLine(borderPen, 0, 1, this.Width, 1);
            g.DrawLine(borderPen, 0, this.Height - 1, this.Width, this.Height - 1);
            g.DrawLine(borderPen, 1, 0, 1, this.Height);
            g.DrawLine(borderPen, this.Width - 1, 0, this.Width - 1, this.Height);

            // Clean-up
            pen.Dispose();
            borderPen.Dispose();
        }

        protected void placeTileAt(int row, int col)
        {
            // TODO: Implement
        }

        public void rotate()
        {
            this.matrx.rotateCW();
            this.Refresh();
        }

        public void setPlayer(CurrentPlayer p)
        {
            this.player = p;
        }

        #region Mouse Methods
        private void BoardControl_MouseOver(object sender, MouseEventArgs e)
        {
            bool inXBounds = e.X > 0 && e.X < this.Width;
            bool inYBounds = e.Y > 0 && e.Y < this.Height;
            if (inXBounds && inYBounds)
            {
                int row = (int)Math.Floor(e.Y / TILE_SIZE);
                int col = (int)Math.Floor(e.X / TILE_SIZE);
//                matrx[row][col] = this._colorNum + 1;
//                this.Refresh();
                //                Console.WriteLine("{2} {0} {1}", row, col, matrx[row][col]);

            }
        }

        private void BoardControl_MouseClick(object sender, MouseEventArgs e)
        {
            bool inXBounds = e.X > 0 && e.X < this.Width;
            bool inYBounds = e.Y > 0 && e.Y < this.Height;
            if (inXBounds && inYBounds)
            {
                int row = (int)Math.Floor(e.Y / TILE_SIZE);
                int col = (int)Math.Floor(e.X / TILE_SIZE);
                for (int matrx_i = row+1, tile_i = player.selectedPiece.height;
                     matrx_i > row - 5 && tile_i >= 0; 
                     matrx_i--, tile_i--) {
                    for (int matrx_j = col, tile_j = 0;
                         matrx_j < col + 5 && tile_j < 5;
                         matrx_j++, tile_j++) {
                        try
                        {
                            if (player.selectedPiece[tile_i][tile_j] == 1)
                            {
                                if (matrx[matrx_i][matrx_j] != 0) matrx[matrx_i][matrx_j] = 5;
                                else matrx[matrx_i][matrx_j] = this._colorNum + 1;
                            }
                                
                        }
                        catch (Exception) { continue; }
                    }
                }
                this.Refresh();
            }
        }
        #endregion
    }

    /// <summary>
    /// Class to allow the board to be manipulated like a tile.
    /// </summary>
    class BoardMatrix : Tile
    {
        public BoardMatrix(int row, int col)
            : base(row, col)
        { }
    }
}
