using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApplications.Blokus
{
    public partial class BlokusGame : Form
    {
        public static Color[] colors = new Color[] { Color.DodgerBlue, Color.FromArgb(253, 253, 0), Color.Red, Color.Lime };
        List<Player> players = new List<Player>(4);
        private CurrentPlayer currentPlayer;
        private int turn = 0;
        private Thread nextturn;

        public BlokusGame()
        {
            InitializeComponent();
            player1 = new Player("J", colors[0]);
            player2 = new Player("Mom", colors[1]);
            player3 = new Player("Chippy", colors[2]);
            player4 = new Player("Tim", colors[3]);
            players.AddRange(new Player[] { player1, player2, player3, player4 });
        }

        private void Blokus_Load(object sender, EventArgs e)
        {
            // Assign the current player and set the controls
            currentPlayer = players[0].convertToCurrentPlayer(pieceControl, pieceSelectControl);
            pieceSelectControl.player = currentPlayer;
            //            currentPlayer.control = pieceControl;
            //            currentPlayer.selectControl = pieceSelectControl;

            // Load the player name tags
            currentPlayerControl.init(currentPlayer);
            player2Control.init(players[1]);
            player3Control.init(players[2]);
            player4Control.init(players[3]);

            // Load the current players pieces
            currentPlayer.refreshControls();
            // currentPlayer.selectControl.Reload(currentPlayer, e);

            // Set the color of the tile that is being played
            matrx._colorNum = this.turn % 4;

            // Pass the player to the board control
            matrx.setPlayer(currentPlayer);

//            this.pieceSelectControl = currentPlayer.selectControl;
//            this.pieceSelectControl.Refresh();
        }

        private void board_MouseMove(object sender, MouseEventArgs e)
        {
            //            Console.WriteLine("{0} {1}", Math.Floor(e.X / TILE_SIZE), Math.Floor(e.Y / TILE_SIZE));
        }

        // Causes the players to rotate order
        private void nextTurn()
        {
            this.turn++;
            //            try
            //            {
            //                players[0].hand.RemoveAt(players[0].hand.Count -1);
            //            }
            //            catch
            //            {
            //                this.Dispose();
            //            }

            int end = players.Count - 1;
            Player temp = players[0]; // Store a temporary variable

            for (int i = 1; i <= end; i++)
            {
                players[i - 1] = players[i]; // Clockwise (right to left) swap
            }
            players[end] = temp; // Reassign the temporary 
        }


        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            players[0] = currentPlayer; // Store the current player back into a normal player

            nextTurn(); // rotate the players
            this.matrx.rotate();

            Blokus_Load(sender, e); // Reload the controls

        }
        #region Tile Buttons
        private void rotateCWButton_Click(object sender, EventArgs e) { pieceControl.rotateCW(); }
        private void rotateCCWbutton_Click(object sender, EventArgs e) { pieceControl.rotateCCW(); }
        private void flipVButton_Click(object sender, EventArgs e) { pieceControl.flipVert(); }
        private void flipHbutton_Click(object sender, EventArgs e) { pieceControl.flipHor(); }
        #endregion

    }
}
