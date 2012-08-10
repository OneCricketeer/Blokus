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
    public partial class PlayerResultsControl : UserControl
    {
        public PlayerResultsControl()
        {
            InitializeComponent();
        }

        public void setup(Player p)
        {
            this.nameLabel.Text = p.Name;
            this.numPieces.Text = p.piecesLeft.ToString();
            this.score.Text = p.Score.ToString();
            this.BackColor = p.color;
        }
    }
}
