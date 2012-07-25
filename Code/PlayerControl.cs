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
    public partial class PlayerControl : UserControl
    {
        public Player player;
        public PlayerControl()
        {
            InitializeComponent();
        }
        public PlayerControl(Player p)
            : this()
        {
            this.player = p;
            this.playerName.Text = p.Name;
            this.playerName.BackColor = p.Color;
            this.numleft.Text = p.piecesLeft.ToString();
        }
    }
}
