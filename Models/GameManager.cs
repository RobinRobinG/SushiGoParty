using System.Collections.Generic;
using System.Linq;

namespace SushiGo.Models
{
    public class GameManager
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public CardDeck DrawPile { get; set; }
        public List<Card> DiscardPile { get; set; }
        public GameManager()
        {
            Player1 = new Player();
            Player2 = new Player();
            DrawPile = new CardDeck();
            DrawPile.Shuffle();

        }
    }
}