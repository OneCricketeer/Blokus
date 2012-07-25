using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using System.Collections.Generic;

namespace ConsoleApplications.Blokus
{
    public partial class BlokusGame : Form
    {
        public static Color[] colors = new Color[] { Color.DodgerBlue, Color.FromArgb(253, 253, 0), Color.Red, Color.Lime };
        List<Player> players = new List<Player>(4);
        private Player currentPlayer;
//        PieceTester f2; 
        private const float TILE_SIZE = 20;
        private int turn = 0;

        public BlokusGame()
        {
            InitializeComponent();
            player1 = new Player("Cricket", colors[0]);
            player2 = new Player("Devon", colors[1]);
            player3 = new Player("Neil", colors[2]);
            player4 = new Player("Ruji", colors[3]);
            players.AddRange(new Player[] { player1, player2, player3, player4 });
            currentPlayer = players[turn];
        }

        private void Blokus_Load(object sender, EventArgs e)
        {
            currentPlayer = players[0];
            // Set the names
            player1Name.Text = currentPlayer.Name;
            player2Name.Text = players[1].Name;//= player2.Name;
            player3Name.Text = players[2].Name;//= player3.Name;
            player4Name.Text = players[3].Name;//= player4.Name;

            //Set the colors
            player1Name.BackColor = currentPlayer.Color;
            player2Name.BackColor = players[1].Color;//= player2.Color;
            player3Name.BackColor = players[2].Color;//= player3.Color;
            player4Name.BackColor = players[3].Color;//= player4.Color;

            // Display the number of pieces each player has left
            player1Num.Text = currentPlayer.piecesLeft.ToString();
            player2Num.Text =  players[1].piecesLeft.ToString(); //= player2.piecesLeft.ToString();
            player3Num.Text =  players[2].piecesLeft.ToString(); //= player3.piecesLeft.ToString();
            player4Num.Text = players[3].piecesLeft.ToString(); //= player4.piecesLeft.ToString();

            pieceControl.player = currentPlayer;
            pieceSelectControl.player = currentPlayer;
            pieceSelectControl.Refresh();
            pieceControl.Refresh();
            
          
//            playerControl1.player = currentPlayer;
//            playerControl2 = new PlayerControl(player2);
//            playerControl3 = new PlayerControl(player3);
//            playerControl4 = new PlayerControl(player4);
            // TODO: Delete this. 
//            f2 = new PieceTester(); // Shows the piece test window
//            f2.Show();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Board GridLines
            Pen pen = new Pen(Color.Black);

            for (double x = this.board.Bounds.Left; x < this.board.Bounds.Right; x += TILE_SIZE)
            {
                g.DrawLine(pen, (int)x, this.board.Bounds.Top, (int)x, this.board.Bounds.Bottom);
            }
            for (double y = this.board.Bounds.Top; y < this.board.Bounds.Bottom; y += TILE_SIZE)
            {
                g.DrawLine(pen, this.board.Bounds.Left, (int)y, this.board.Bounds.Right, (int)y);
            }
        }

        private void board_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("{0} {1}", Math.Floor(e.X / TILE_SIZE), Math.Floor(e.Y / TILE_SIZE));
        }

        // Causes the players to rotate order
        private void nextTurn()
        {
            this.turn++;
            int end = players.Count -1;
            Player temp = players[end];
            for (int i = 0; i < end; i++)
            {
                try
                {
                 players[i -1] = players[i];   
                }
                catch (Exception)
                {
                    players[end] = players[0];
                }
            }
            players[end - 1] = temp;

            // TODO: Rotate the board so the bottom left corner is for the current players tiles
//            this.Refresh();
        }

        #region Tile Buttons
        private void rotateCWButton_Click(object sender, EventArgs e)
        {
//            f2.selectedPiece.rotateCW();
            pieceControl.rotateCW();
//            f2.Refresh();
        }

        private void rotateCCWbutton_Click(object sender, EventArgs e)
        {
//            f2.selectedPiece.rotateCCW();
            pieceControl.rotateCCW();
//            f2.Refresh();
        }

        private void flipVButton_Click(object sender, EventArgs e)
        {
//            f2.selectedPiece.flipVert();
//            f2.Refresh();
            pieceControl.flipVert();
        }

        private void flipHbutton_Click(object sender, EventArgs e)
        {
//            f2.selectedPiece.flipHor();
//            f2.Refresh();
            pieceControl.flipHor();
        }
        #endregion

        private void placeTileButton_Click(object sender, EventArgs e)
        {
            nextTurn();
//            currentPlayer.removePiece(pieceControl.piece);
            Blokus_Load(sender, e);
        }
    }
}
