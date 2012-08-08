using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApplications.Blokus
{
    public partial class ResultForm : Form
    {

        public ResultForm()
        {
            InitializeComponent();
        }

        public ResultForm(List<Player> players)
            : this()
        {
            Player winner = players[0];
            for (int i = 1; i < players.Count; i++)
            {
                if (winner.Score < players[i].Score)
                {
                    winner = players[i];
                }
            }

            winnerLabel.Text = winnerLabel.Text.Replace("<player>", winner.Name);
            winnerLabel.BackColor = winner.Color;

            player1Results.setup(players[0]);
            player2Results.setup(players[1]);
            player3Results.setup(players[2]);
            player4Results.setup(players[3]);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // TODO: Start a new game
            this.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // TODO: Dispose of the parent
            this.Dispose();
        }
    }
}
