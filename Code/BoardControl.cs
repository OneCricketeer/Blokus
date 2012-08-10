using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplications.Blokus
{
    public partial class BoardControl : UserControl
    {
        #region Fields...
        private const float TILE_SIZE = 20;
        private BoardMatrix matrx;
        public int _colorNum = 0;
        public Color color;
        private CurrentPlayer player;
        #endregion
        #region Constructors...
        public BoardControl()
        {
            InitializeComponent();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer, true);
            matrx = new BoardMatrix((int)TILE_SIZE, (int)TILE_SIZE);
        }
        #endregion
        public void setup(CurrentPlayer p, int turnNumber)
        {
            this.player = p;
            this._colorNum = turnNumber % 4;
            // TODO: Delete this
            //            int num = 0;
            //            for (int i = 0; i < matrx.width; i++)
            //            {
            //                for (int j = 0; j < matrx.height; j++)
            //                {
            //                    if (i >= 10)
            //                        num = 5;
            //                    if (i >= 12)
            //                        num = 6;
            //                    if (i >= 14)
            //                        num = 7;
            //                    if (i >= 16)
            //                        num = 8;
            //                    matrx[i][j] = num;
            //                }
            //            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            #region GridLines
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
            #endregion

            #region Text
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;
            fmt.LineAlignment = StringAlignment.Center;
            Font drawFont = new Font("Time New Roman", 12);
            #endregion

            #region Loop Variables
            int i = 0;
            int j = 0;
            int tile = 0;
            int tile_num;
            #endregion

            // Draw
            for (float y = 0; y < this.Height; y += TILE_SIZE, i++)
            {
                j = 0;
                for (float x = 0; x < this.Width; x += TILE_SIZE, j++)
                {
                    #region String setter
                    try
                    {
                        if (matrx[i][j] == 9) // Overlapping
                            tile = 9;
                        else if (matrx[i][j] < 0)
                            tile = -1 * matrx[i][j];
                        else if (matrx[i][j] >= 5 && matrx[i][j] < 9)
                            tile = matrx[i][j] - 4;
                        else if (matrx[i][j] >= 0 && matrx[i][j] < 5)
                            tile = matrx[i][j];
                    }
                    catch (Exception) { continue; }
                    #endregion

                    if (tile != 0)
                    {
                        tile_num = matrx[i][j];

                        #region Color setter
                        if (tile_num == 0)
                            continue;
                        else if (tile_num == 9 || tile_num < 0)
                            this.color = Color.White;
                        else if (5 <= tile_num && tile_num < 9)
                            this.color = BlokusGame.colors[(tile_num - 1) % 4];
                        else if (1 <= tile_num && tile_num <= 4)
                            this.color = BlokusGame.colors[tile_num - 1];
                        //                        Console.WriteLine(tile_num);
                        #endregion

                        //                        this.color = matrx[i][j] > 4 || matrx[i][j] < 0 ? Color.White : BlokusGame.colors[matrx[i][j] - 1];
                        #region Cell drawer
                        RectangleF drawRect = new RectangleF(x, y, TILE_SIZE, TILE_SIZE);
                        Rectangle cell = new Rectangle((int)drawRect.X, (int)drawRect.Y, (int)drawRect.Width, (int)drawRect.Height);
                        e.Graphics.FillRectangle(new SolidBrush(this.color), cell);
                        e.Graphics.DrawRectangle(new Pen(Color.Black, 1), cell);
                        e.Graphics.DrawString(tile.ToString(), drawFont, new SolidBrush(Color.Black), drawRect, fmt);
                        #endregion
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


        public void rotate()
        {
            this.matrx.rotateCW();
            this.Refresh();
        }

        #region Mouse Methods
        private void BoardControl_MouseOver(object sender, MouseEventArgs e)
        {
            #region Local Variables
            bool inXBounds = e.X > 0 && e.X < this.Width;
            bool inYBounds = e.Y > 0 && e.Y < this.Height;
            bool clicked = false;
            int prevRow = 0, prevCol = 0;
            int z;
            #endregion

            // Undraw entire board while no click is pressed
            if (MouseButtons.None.Equals(e.Button))
            {
                for (int i = 0; i < matrx.width; i++)
                {
                    for (int j = 0; j < matrx.height; j++)
                    {
                        z = matrx[i][j];
                        if (z == 0 || 5 <= z && z < 9) continue;
                        if (0 < z && z < 5)
                        {
                            matrx[i][j] = 0; // Undraw "hovering" pieces
                        }

                        else if (z == 9)
                            matrx[i][j] = -1 * z;
                        else if (z < 0)
                            matrx[i][j] *= -1; // Un-whiten "overlapping" pieces
                    }
                }
            }
            else if (MouseButtons.Left.Equals(e.Button))
            {
                clicked = true;
            }

            else
            {
                clear();
            }

            if (!clicked) // Blocks click & drag
                this.BoardControl_MouseClick(sender, e); // Shows an overlap of the selected piece
            else
                return;

            this.Refresh();
            //            }
        }

        private void clear()
        {
            for (int i = 0; i < matrx.width; i++)
            {
                for (int j = 0; j < matrx.height; j++)
                {
                    matrx[i][j] = 0;
                }
            }
        }

        private void BoardControl_MouseClick(object sender, MouseEventArgs e)
        {
            #region Local Variables
            bool inXBounds = e.X > 0 && e.X < this.Width;
            bool inYBounds = e.Y > 0 && e.Y < this.Height;
            bool clicked = false;
            int prevRow = 0, prevCol = 0;
            #endregion

            // Undraw entire board while no click is pressed
            //            if (MouseButtons.None.Equals(e.Button))
            //            {
            //                for (int i = 0; i < 20; i++)
            //                {
            //                    for (int j = 0; j < 20; j++)
            //                    {
            //                        z = matrx[i][j];
            //                        if (z == 0) continue;
            //                        else if (0 < z && z < 5) {
            ////                            Console.WriteLine(z);
            //                            matrx[i][j] = 0;
            //                        }
            //                            
            //                        else if (z == 9)
            //                            matrx[i][j] = _colorNum + 1;
            //                    }
            //                }
            //            }

            if (MouseButtons.Left.Equals(e.Button) && (inXBounds && inYBounds))
            {
                clicked = true;
            }

            if (inXBounds && inYBounds)
            {
                // Caluculate the coordinates of the mouse in the board
                int row = (int)Math.Floor(e.Y / TILE_SIZE);
                if (prevRow != row) prevRow = row;
                int col = (int)Math.Floor(e.X / TILE_SIZE);
                if (prevCol != col) prevCol = col;

                // Get the bottom offset of the piece
                int offset = player.selectedPiece.getOffset();

                // This is a little messy but it paints the piece at the location of the mouse on the board
                for (int matrx_i = prevRow + 1, tile_i = player.selectedPiece.height;
                     matrx_i > prevRow - 5 && tile_i >= 0;
                     matrx_i--, tile_i--)
                {
                    #region Piece Offset
                    // The mouse starts on the first square in the bottom row
                    int tile_j;
                    if (tile_i == player.selectedPiece.height - 1) // the bottom row
                    {
                        tile_j = offset;
                    }
                    else // the rows above the bottom
                    {
                        tile_j = 0;
                    }
                    #endregion

                    for (int matrx_j = prevCol - offset + tile_j;
                         matrx_j < prevCol + 5 && tile_j < 5;
                         matrx_j++, tile_j++)
                    {
                        try
                        {
                            if (player.selectedPiece[tile_i][tile_j] == 1) //&& matrx[matrx_i][matrx_j] != 0) // Only look at the selected piece
                            {
                                int x = matrx[matrx_i][matrx_j];
                                /*
                                 * If 9, continue
                                 * If x == 0 (cells are blank)
                                 * If 1 < x < 5, x = _colorNum + 5
                                 * If 5 < x < 9, x = 9
                                 */
                                //                                if (x == 0 && clicked)
                                //                                    Console.WriteLine("What do?");
                                //                                if (1 <= x && x < 5)
                                //                                {
                                //                                    //                                    Console.WriteLine(x);
                                //                                    //                                    Console.WriteLine("Ummm " + x);
                                //                                    matrx[matrx_i][matrx_j] = _colorNum + 1;
                                //                                }

                                if (5 <= x && x < 9)
                                {
                                    //                                    Console.WriteLine("Overlapping");
                                    //                                    overlap = true;
                                    matrx[matrx_i][matrx_j] *= -1; // overlap  
                                }

                                else if (x == 0)
                                {
                                    if (clicked)
                                        matrx[matrx_i][matrx_j] = _colorNum + 5;
                                    else
                                        matrx[matrx_i][matrx_j] = _colorNum + 1;
                                }
                                else
                                {
                                    // else x < 0 OR x > 9 
                                    if (clicked)
                                        matrx[matrx_i][matrx_j] = _colorNum + 5;


                                }
                            }
                        }
                        catch (Exception) { continue; }
                    }
                }
            }
        }


        private void BoardControl_MouseLeave(object sender, EventArgs e)
        {
            for (int tile_i = 0; tile_i < player.selectedPiece.height; tile_i++)
            {
                for (int tile_j = 0; tile_j < player.selectedPiece.width; tile_j++)
                {
                    try
                    {
                        player.selectedPiece[tile_i][tile_j] = 0;
                    }
                    catch (Exception)
                    {
                        continue;
                    }

                }
            }
            this.Refresh();
        }
        #endregion

        protected override void OnMouseDown(MouseEventArgs e)
        {
            clear();
        }
        //
        //        protected override void OnMouseUp(MouseEventArgs e)
        //        {
        //            this._colorNum -= 4;
        //        }
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
