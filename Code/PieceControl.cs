using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplications.Blokus
{
    public partial class PieceControl : UserControl
    {
        protected float TILE_SIZE;
        public int piece_index;
        public Tile piece;
        public CurrentPlayer player;

        #region Constructors
        public PieceControl()
        {
            InitializeComponent();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer, true);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TILE_SIZE = 10;
        }

        public PieceControl(Tile piece)
            : this()
        {
            this.piece = piece;
        }

        public PieceControl(Player player, Tile piece) : this(piece)
        {
            int i = 0;
            foreach (Tile t in player.hand)
            {
                if (t.Equals(piece))
                {
                    piece_index = i;
                    break;
                }
                i++;
            }
        }

        public PieceControl(CurrentPlayer p)
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

        public virtual void center(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float xOffset = ((8 - this.piece.width) * TILE_SIZE) / 2;
            float yOffset = ((6 - this.piece.height) * TILE_SIZE) / 2 + 1;
            g.TranslateTransform(xOffset, yOffset);
        }

        public void setup(CurrentPlayer player)
        {
            this.player = player;
        }

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

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            center(e);
            Pen pen = new Pen(Color.Black, 1);
            SolidBrush drawBrush = new SolidBrush(player.Color);
            String tile;

            int i = 0;
            int j = 0;
            // Draw
            for (float y = 0; y < this.Height && i < 5; y += TILE_SIZE, i++)
            {
                j = 0;
                for (float x = 0; x < this.Width && j < 5; x += TILE_SIZE, j++)
                {
                    try
                    {
                        tile = Convert.ToString(piece[i][j]);
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
                    }

                }
            }
        }


        private void pieceBorder_MouseClick(object sender, MouseEventArgs e)
        {
            select();
        }

        public void select()
        {
            // Gives the illusion of swapping pieces
            swap<Tile>(ref this.piece, ref player.selectedPiece); // Swaps the clicked piece and the selected piece
            player.hand[piece_index] = this.piece;

            // Redraw the controls
            this.Refresh(); // Refreshes this control, drawing the previously selected piece
            player.control.Refresh(); // Refreshes the selected piece control, drawing the clicked piece
        }

        public void swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
    public class SelectedPieceControl : PieceControl
    {
        public SelectedPieceControl()
            : base(40)
        {
            this.pieceBorder.Visible = false;
            this.pieceBorder.Size = new Size(200, 200);
            base.Cursor = System.Windows.Forms.Cursors.Default;
            if (this.player != null)
                this.piece = player.selectedPiece;
        }
        public SelectedPieceControl(Tile piece)
            : this()
        {
            this.piece = piece;
        }

        public SelectedPieceControl(CurrentPlayer p)
            : base(p)
        {
            this.piece = p.selectedPiece;
        }

        public override void center(PaintEventArgs e)
        {
            base.center(e);
            Graphics g = e.Graphics;
            float xOffset = -(3 * TILE_SIZE / 2);
            float yOffset = -(1 + 1 * TILE_SIZE / 2);
            g.TranslateTransform(xOffset, yOffset);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.player != null) {
                 this.piece = this.player.selectedPiece;
                base.OnPaint(e);
            }
        }
    }
}
