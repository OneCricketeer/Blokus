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
            player1 = new Player("Cricket", colors[0]);
            player2 = new Player("Devon", colors[1]);
            player3 = new Player("Neil", colors[2]);
            player4 = new Player("Ruji", colors[3]);
            players.AddRange(new Player[] { player1, player2, player3, player4 });
        }

        private void Blokus_Load(object sender, EventArgs e)
        {
            // Assign the current player and set the controls
            this.currentPlayer = players[0].convertToCurrentPlayer(pieceControl, pieceSelectControl);

            // Setup the game
            setup();
        }

        private void setup()
        {
            // PieceControls
            pieceControl.setup(currentPlayer);

            // NameTags
            currentPlayerControl.setup(currentPlayer);
            player2Control.setup(players[1]);
            player3Control.setup(players[2]);
            player4Control.setup(players[3]);

            // Board
            matrx.setup(currentPlayer, this.turn);
            matrx.Refresh();

            // Redraw the player's controls
            currentPlayer.refreshControls();

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

            if (players[0].cannotPlay()) // Skip a player if they cannot play
            {
                bool allFinished = true;
                foreach (Player p in players) // Check if each player is done
                {
                    if (!p.cannotPlay())
                        allFinished = false;
                }
                if (!allFinished)
                {
                    nextTurn(); // Run until the current player can play
                }
                else
                {
                    ResultForm results = new ResultForm(players);
                    results.ShowDialog();
                }
            }
        }


        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            players[0] = currentPlayer; // Store the current player back into a normal player

            nextTurn(); // rotate the players
            this.matrx.rotate(); // rotate the board

            Blokus_Load(sender, e); // Reload the controls

        }
        #region Tile Buttons
        private void rotateCWButton_Click(object sender, EventArgs e) { pieceControl.rotateCW(); }
        private void rotateCCWbutton_Click(object sender, EventArgs e) { pieceControl.rotateCCW(); }
        private void flipVButton_Click(object sender, EventArgs e) { pieceControl.flipVert(); }
        private void flipHbutton_Click(object sender, EventArgs e) { pieceControl.flipHor(); }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            currentPlayer.isDone();
        }

        private void matrx_MouseEnter(object sender, EventArgs e)
        {
            matrx.BoardControl_MouseEnter(sender, e);
        }

        private void matrx_Leave(object sender, EventArgs e)
        {
            matrx.BoardControl_MouseLeave(sender, e);
        }



    }
}
