using System;
using System.Collections.Generic;
using System.Linq;

namespace SushiGo.Models
{
    public class CardDeck
    {
        public List<Card> Cards { get; set; }

        public CardDeck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                Cards.Add(new Nigiri1Card());
                Cards.Add(new Nigiri2Card());
                Cards.Add(new Nigiri3Card());
                Cards.Add(new Maki1Card());
                Cards.Add(new Maki2Card());
                Cards.Add(new Maki3Card());
            }
            for (int i = 0; i < 8; i++)
            {
                Cards.Add(new SashimiCard());
                Cards.Add(new TofuCard());
                Cards.Add(new MisoSoupCard());
            }
            for (int i = 0; i < 3; i++)
            {
                Cards.Add(new SoySauceCard());
                Cards.Add(new TeaCard());
            }
            for (int i = 0; i < 10; i++)
            {
                Cards.Add(new PuddingCard());
            }
        }
        public void Shuffle()
        {
            Random r = new Random();

            List<Card> cards = Cards;

            for (int n = cards.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                Card temp = cards[n];
                cards[n] = cards[k];
                cards[k] = temp;
            }
        }
        public List<Card> Draw(int count)
        {
            var drawnCards = Cards.Take(count).ToList();
            Cards.RemoveAll(x => drawnCards.Contains(x));
            return drawnCards;
        }
    }
}