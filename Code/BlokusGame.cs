using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplications.Blokus
{
    public partial class BlokusGame : Form
    {
        public static Color[] colors = new Color[] { Color.DodgerBlue, Color.Yellow, Color.Red, Color.Lime };
        private Player player1; 
        private Player player2; 
        private Player player3; 
        private Player player4;
        PieceTester f2;
        private const double TILE_SIZE = 20;

        public BlokusGame()
        {
            InitializeComponent();
            player1 = new Player("Cricket", colors[0]);
            player2 = new Player("Alex", colors[1]);
            player3 = new Player("Neil", colors[2]);
            player4 = new Player("Ruji", colors[3]);
        }

        private void Blokus_Load(object sender, EventArgs e)
        {
            
            player1Name.Text = player1.Name;
            player2Name.Text = player2.Name;
            player3Name.Text = player3.Name;
            player4Name.Text = player4.Name;

            player1Name.ForeColor = player1.Color;
            player2Name.ForeColor = player2.Color;
            player3Name.ForeColor = player3.Color;
            player4Name.ForeColor = player4.Color;

            player1Num.Text = player1.piecesLeft.ToString();
            player2Num.Text = player2.piecesLeft.ToString();
            player3Num.Text = player3.piecesLeft.ToString();
            player4Num.Text = player4.piecesLeft.ToString(); 
            f2 = new PieceTester();
            f2.Show();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // GridLines
            Pen pen = new Pen(Color.Black);
            
            for (double x = this.board.Bounds.Left; x < this.board.Bounds.Right; x += TILE_SIZE)
            {
                e.Graphics.DrawLine(pen, (int) x, this.board.Bounds.Top, (int) x, this.board.Bounds.Bottom);
            }
            for (double y = this.board.Bounds.Top; y < this.board.Bounds.Bottom; y += TILE_SIZE)
            {
                e.Graphics.DrawLine(pen, this.board.Bounds.Left, (int)y, this.board.Bounds.Right, (int) y);
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            optionText.Text = "Rotated";
            f2.selectedPiece.rotateCW();
            f2.Refresh();
        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            optionText.Text = "Flipped";
            f2.selectedPiece.flipVert();
            f2.Refresh();
        }

        private void placeTile(object sender, EventArgs e)
        {
            // TODO: Implement
        }

        private void board_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("{0} {1}", Math.Floor(e.X / TILE_SIZE), Math.Floor(e.Y/TILE_SIZE));
        }
    }
}
