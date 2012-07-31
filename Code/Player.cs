
using System.Collections;
using System;
namespace ConsoleApplications.Blokus
{
    public class Player
    {
        public PlayerControl nameTag;
        private TileGenerator tg = new TileGenerator();
        public string Name;
        public System.Drawing.Color Color;
        public static int counter = 0;
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
        public ArrayList hand = new ArrayList();
        public int piecesLeft { get { return hand.Count; } }


        public Player()
        {
            tg.generate();
            this.hand = tg.hand;
            int random = new Random().Next(0, piecesLeft - 1);
            this.selectedPiece = (Tile)hand[random];

            counter++;
//            Console.WriteLine(counter + ": Where are you?");

        }

        public Player(string Name)
            : this()
        {
            this.Name = Name;
        }

        public Player(string Name, System.Drawing.Color Color)
            : this(Name)
        {
            this.Color = Color;
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
//            Console.WriteLine(this.Name + " removed\n{0}", piece);
        }

        public CurrentPlayer convertToCurrentPlayer()
        {
            CurrentPlayer c = new CurrentPlayer();
            c.Name = this.Name;
            c.hand = this.hand;
            c.Color = this.Color;
            c.selectedPiece = this.selectedPiece;
            return c;
        }

        public CurrentPlayer convertToCurrentPlayer(SelectedPieceControl c, SelectionControl s)
        {
            CurrentPlayer curr = new CurrentPlayer(c, s);
            curr.Name = this.Name;
            curr.hand = this.hand;
            curr.Color = this.Color;
            curr.selectedPiece = this.selectedPiece;
            return curr;
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

        public void refreshControls()
        {
            this.control.Refresh();
            this.selectControl.Refresh();
        }
    }
}
