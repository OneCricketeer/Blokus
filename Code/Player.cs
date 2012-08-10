
using System.Collections;
using System;
namespace ConsoleApplications.Blokus
{
    public class Player
    {
        public PlayerControl nameTag;
        private TileGenerator tg = new TileGenerator();
        public string Name;
        public System.Drawing.Color color;
        protected bool finished;
        public int Score
        {
            get
            {
                int sum = 0;
                foreach (Tile t in hand)
                {
                    sum += t.score;
                }
                return sum;
            }
        }

        public Tile selectedPiece;
        public ArrayList hand;
        public int piecesLeft
        {
            get
            {
                Tile blank = new Tile();
                int total = 0;
                foreach (Tile t in this.hand)
                {
                    if (!t.Equals(blank))
                    {
                        total++;
                    }
                } 
                return total;
            }
        }


        public Player()
        {
            if (this.hand == null)
            {
                tg.generate();
                this.hand = tg.hand;
            }

            int random = new Random().Next(0, piecesLeft - 1);
            this.selectedPiece = (Tile)hand[random];
            this.finished = false;
        }

        public Player(string Name)
            : this()
        {
            this.Name = Name;
        }

        public Player(string Name, System.Drawing.Color color)
            : this(Name)
        {
            this.color = color;
            removePiece(selectedPiece);
        }

        public void removePiece(Tile piece)
        {

            for (int i = 0; i < hand.Count; i++)
            {
                Tile tileInHand = (Tile)hand[i];
                if (tileInHand.Equals(piece))
                {
                    hand.RemoveAt(i);
                    break;
                }
            }
        }

        public void isDone()
        {
            this.finished = true;
        }

        public bool cannotPlay()
        {
            return this.finished;
        }

        public CurrentPlayer convertToCurrentPlayer()
        {
            CurrentPlayer c = new CurrentPlayer();
            c.Name = this.Name;
            c.hand = this.hand;
            c.color = this.color;
            c.selectedPiece = this.selectedPiece;
            return c;
        }

        public CurrentPlayer convertToCurrentPlayer(SelectedPieceControl c, SelectionControl s)
        {
            return new CurrentPlayer(this, c, s);
        }
    }

    public class CurrentPlayer : Player
    {
        public SelectedPieceControl control;
        public SelectionControl selectControl;
        public CurrentPlayer()
            : base() { }

        public CurrentPlayer(SelectedPieceControl c, SelectionControl s)
            : this()
        {
            c.player = this;
            s.player = this;
            this.control = c;
            this.selectControl = s;
        }
        public CurrentPlayer(Player p)
        {
            this.Name = p.Name;
            this.hand = p.hand;
            this.color = p.color;
            this.selectedPiece = p.selectedPiece;
            this.finished = p.cannotPlay();
        }

        public CurrentPlayer(Player p, SelectedPieceControl c, SelectionControl s)
            : this(p)
        {
            c.player = this;
            s.player = this;
            this.control = c;
            this.selectControl = s;
        }

        public void refreshControls()
        {
            this.control.Refresh();
            this.selectControl.redraw();
        }
    }
}
