
using System.Collections;
namespace ConsoleApplications.Blokus
{
    class Player
    {
        private TileGenerator tg = new TileGenerator();
        public string Name;
        public System.Drawing.Color Color;
        public int piecesLeft;
        public ArrayList hand = new ArrayList(); 

        public Player()
        {
            tg.generate();
            this.hand = tg.hand;
            this.piecesLeft = this.hand.Count;
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
    }
}
