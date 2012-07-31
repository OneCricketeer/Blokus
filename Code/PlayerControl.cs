using System.Windows.Forms;

namespace ConsoleApplications.Blokus
{
    public partial class PlayerControl : UserControl
    {
        public PlayerControl()
        {
            InitializeComponent();
        }
        public PlayerControl(Player p)
            : this()
        {
            this.playerName.Text = p.Name;
            this.playerName.BackColor = p.Color;
            this.numleft.Text = p.piecesLeft.ToString();
            this.scoreNum.Text = p.Score.ToString();
        }
        public void init(Player p) 
        {
            this.playerName.Text = p.Name;
            this.playerName.BackColor = p.Color;
            this.numleft.Text = p.piecesLeft.ToString();
            this.scoreNum.Text = p.Score.ToString();
            this.Refresh();
            p.nameTag = this;
            p.nameTag.Refresh();
        }
    }
}
