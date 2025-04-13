using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK_2;

namespace TASK_2
{
    internal class Deck
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
            for (int i = 0; i < cards.Count; i++)
            {
                Random rand = new Random();
                int j = rand.Next(i + 1);
                (cards[i], cards[j]) = (cards[j], cards[i]); //swapping without third variable
            }
        }
        public int CardsLeft()
        {
            return count;
        }
        public Card DealCard()
        {
            if (count > 0)
            {
                count--;
                return cards[count];
            }

            else return null;
        }
    }
}



