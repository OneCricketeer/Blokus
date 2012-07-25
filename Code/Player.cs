
using System.Collections;
namespace ConsoleApplications.Blokus
{
    public class Player
    {
        private TileGenerator tg = new TileGenerator();
        public string Name;
        public System.Drawing.Color Color;
        public int piecesLeft { get { return hand.Count; } }
        public ArrayList hand = new ArrayList(); 

        public Player()
        {
            tg.generate();
            this.hand = tg.hand;
        }

        public Player(string Name) : this() 
        {
            this.Name = Name;
        }

        public Player(string Name, System.Drawing.Color Color)
            : this(Name)
        {
            this.Color = Color;
        }

        public void removePiece(Tile piece) 
        {
            int index = hand.IndexOf(piece);
            hand[index] = new Tile();
        }
    }
}
