using System;
using System.Drawing;
using System.Windows.Forms;
using ConsoleApplications.Blokus;

namespace ConsoleApplications.Blokus
{
    public partial class PieceTester : Form
    {
        private Color[] colors = BlokusGame.colors;
        private static Color playerColor;
        private Player p;
        public Tile selectedPiece;
        private const float TILE_SIZE = 50;

        public PieceTester()
        {
            InitializeComponent();
            p = new Player();
            playerColor = colors[new Random().Next(0, 3)]; // Initialize with a random color instead of black
            selectedPiece = new Tile();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);

            // Text
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;
            fmt.LineAlignment = StringAlignment.Center;
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(playerColor);

            int i = 0;
            int j = 0;
            // Draw
            for (float y = piece.Bounds.Top; y < piece.Bounds.Bottom; y += TILE_SIZE, i++)
            {
                j = 0;
                for (float x = piece.Bounds.Left; x < piece.Bounds.Right; x += TILE_SIZE, j++)
                {
                    String tile;
                    try
                    {
                        tile = selectedPiece[i][j].ToString();
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
                        e.Graphics.FillRectangle(new SolidBrush(playerColor), cell);
                        e.Graphics.DrawRectangle(new Pen(Color.Black, 1), cell);
                        // e.Graphics.DrawString(tile, drawFont, new SolidBrush(Color.Black), drawRect, fmt);
                    }

                }
            }

        }

        private void playerbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int player = Convert.ToInt32(b.Text);
            playerColor = colors[player - 1];
            this.Refresh();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //  label1.Text = comboBox1.Text;
            int i = Convert.ToInt32(comboBox1.Text);
            selectedPiece = (Tile)p.hand[i - 1];
            //  Console.WriteLine(selectedPiece);
            this.Refresh();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBox1.Text);
            selectedPiece = (Tile)p.hand[i - 1];
            this.Refresh();
        }

        private void flipHbutton_Click(object sender, EventArgs e)
        {
            selectedPiece.flipHor();
            this.Refresh();
        }

        private void flipVbutton_Click(object sender, EventArgs e)
        {
            selectedPiece.flipVert();
            this.Refresh();
        }

        private void rotCWbutton_Click(object sender, EventArgs e)
        {
            selectedPiece.rotateCW();
            this.Refresh();
        }

        private void rotCCWbutton_Click(object sender, EventArgs e)
        {
            selectedPiece.rotateCCW();
            this.Refresh();
        }
    }
}
