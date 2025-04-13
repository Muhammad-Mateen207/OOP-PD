using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    class Deck
    {
        private List<Card> cards;
        private int count;

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card(value, suit));
                }
            }
            count = 52;
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int j = rand.Next(i, cards.Count);
                (cards[i], cards[j]) = (cards[j], cards[i]);
            }
        }

        public Card DealCard()
        {
            if (count > 0)
            {
                count--;
                return cards[count];
            }
            return null;
        }
    }
}
