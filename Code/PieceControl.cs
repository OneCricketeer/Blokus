using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApplications.Blokus
{
    public partial class PieceControl : UserControl
    {
        public float TILE_SIZE;
        public int piece_index;
        public Tile piece;
        public Player player;

        #region Constructors
        public PieceControl()
        {
            InitializeComponent();
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TILE_SIZE = 10;
            this.player = new Player();
            this.piece_index = new Random().Next(0, player.hand.Count);
            this.piece = (Tile)player.hand[piece_index];
        }
        public PieceControl(Tile piece)
            : this()
        {
            this.piece = piece;
        }

        public PieceControl(Player p)
            : this()
        {
            this.player = p;
        }

        public PieceControl(float size)
            : this()
        {
            this.TILE_SIZE = size;
        }

        public PieceControl(Tile piece, float size)
            : this(piece)
        {
            this.TILE_SIZE = size;
        }
        #endregion

        public void fit()
        {
            this.Size = new System.Drawing.Size((int)(piece[0].Length * TILE_SIZE) + 1, (int)(piece.tile.Count * TILE_SIZE) + 1);
            //            this.Size = new System.Drawing.Size(51, (int)(piece.tile.Count * TILE_SIZE) + 1);
        }
        public virtual void center(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float xOffset = ((8 - this.piece.width) * TILE_SIZE) / 2;
            float yOffset = ((5 - this.piece.height) * TILE_SIZE) / 2;
            g.TranslateTransform(xOffset, yOffset);
        }
        #region Old Paint
        //  protected override void OnPaint(PaintEventArgs e)
        //        {
        //            Pen pen = new Pen(Color.Black);
        //
        //            // Text
        //            StringFormat fmt = new StringFormat();
        //            fmt.Alignment = StringAlignment.Center;
        //            fmt.LineAlignment = StringAlignment.Center;
        //            Font drawFont = new Font("Arial", 16);
        //            SolidBrush drawBrush = new SolidBrush(Color.DodgerBlue);
        //            String tile;
        //            int i = 0;
        //            int j = 0;
        //            // Draw
        //            for (float y = pieceBorder.Bounds.Top; y < pieceBorder.Bounds.Bottom; y += TILE_SIZE, i++)
        //            {
        //                j = 0;
        //                for (float x = pieceBorder.Bounds.Left; x < pieceBorder.Bounds.Right; x += TILE_SIZE, j++)
        //                {
        //
        //                    try
        //                    {
        //                        tile = selectedPiece[i][j].ToString();
        //                    }
        //                    catch (Exception)
        //                    {
        //                        tile = "0";
        //                        continue;
        //                    }
        //
        //                    if (tile != "0")
        //                    {
        //                        RectangleF drawRect = new RectangleF(x, y, TILE_SIZE, TILE_SIZE);
        //                        Rectangle cell = new Rectangle((int)drawRect.X, (int)drawRect.Y, (int)drawRect.Width, (int)drawRect.Height);
        //                        e.Graphics.FillRectangle(new SolidBrush(Color.DodgerBlue), cell);
        //                        e.Graphics.DrawRectangle(new Pen(Color.Black, 1), cell);
        //                        //  e.Graphics.DrawString(tile, drawFont, new SolidBrush(Color.Black), drawRect, fmt);
        //                    }
        //
        //                }
        //            }
        //        }
        #endregion

        #region Tile method callers
        public void rotateCW()
        {
            this.piece.rotateCW();
            this.Refresh();
        }
        public void rotateCCW()
        {
            this.piece.rotateCCW();
            this.Refresh();
        }
        public void flipHor()
        {
            this.piece.flipHor();
            this.Refresh();
        }
        public void flipVert()
        {
            this.piece.flipVert();
            this.Refresh();
        }
        #endregion

        protected void PieceControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            /*
            for (int x = 0; x < this.Height; x += (int)TILE_SIZE)
            {
                g.DrawLine(System.Drawing.Pens.Red, pieceBorder.Left, x,
                    pieceBorder.Right, x);
            }
            for (int y = 0; y < this.Width; y += (int)TILE_SIZE)
            {
                g.DrawLine(System.Drawing.Pens.Red, y, pieceBorder.Top,
                    y, pieceBorder.Bottom);
            }
            /**/
            center(e);

            Pen pen = new Pen(Color.Black, 1);

            // Text
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;
            fmt.LineAlignment = StringAlignment.Center;
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(player.Color);
            String tile;
            int i = 0;
            int j = 0;
            // Draw
            for (float y = pieceBorder.Bounds.Top; y < pieceBorder.Bounds.Bottom && i < 5; y += TILE_SIZE, i++)
            {
                j = 0;
                for (float x = pieceBorder.Bounds.Left; x < pieceBorder.Bounds.Right && j < 5; x += TILE_SIZE, j++)
                {
                    try
                    {
                        tile = piece[i][j].ToString();
                    }
                    catch (Exception)
                    {
                        tile = "0";
                        continue;
                    }

                    if (tile != "0")
                    {
                        RectangleF drawRect = new RectangleF(x, y, TILE_SIZE, TILE_SIZE);
                        Rectangle cell = new Rectangle((int)drawRect.X, (int)drawRect.Y, (int)drawRect.Width, (int)drawRect.Height);
                        g.FillRectangle(drawBrush, cell);
                        g.DrawRectangle(pen, cell);
                        //  e.Graphics.DrawString(tile, drawFont, new SolidBrush(Color.Black), drawRect, fmt);
                    }

                }
            }

        }

        private void pieceControl_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Tile Size: {0}\nBorder Width: {1}\nBorder Height: {2}", this.TILE_SIZE, this.pieceBorder.Width, this.pieceBorder.Height);
        }
    }
    public class SelectedPieceControl : PieceControl
    {
        public SelectedPieceControl()
            : base(40)
        {
            this.Size = new Size(201, 201);
            base.Cursor = System.Windows.Forms.Cursors.Default;
        }

        public override void center(PaintEventArgs e)
        {
            base.center(e);
            Graphics g = e.Graphics;
            float xOffset = -(3*TILE_SIZE / 2);
            g.TranslateTransform(xOffset, 0);
        }
    }
}
