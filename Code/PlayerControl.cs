using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApplications.Blokus
{
    public partial class PlayerControl : UserControl
    {
        public Color color;
        public PlayerControl()
        {
            InitializeComponent();
        }

        public PlayerControl(Player p)
            : this()
        {
            this.playerName.Text = p.Name;
            this.playerName.BackColor = p.color;
            this.numleft.Text = p.piecesLeft.ToString();
            this.scoreNum.Text = p.Score.ToString();
        }
        public void setup(Player p) 
        {
            this.playerName.Text = p.Name;
            this.playerName.BackColor = p.color;
            this.color = p.color;
            this.numleft.Text = p.piecesLeft.ToString();
            this.scoreNum.Text = p.Score.ToString();
            p.nameTag = this;
            p.nameTag.Refresh();
        }
    }
}
