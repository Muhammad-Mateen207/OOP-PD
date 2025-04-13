using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    class Hand
    {
        protected List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            if (card != null) cards.Add(card);
        }

        public void Display(string title)
        {
            Console.WriteLine($"\n{title} Hand:");
            foreach (var card in cards)
            {
                Console.WriteLine(" - " + card);
            }
        }

        public List<Card> GetCards()
        {
            return cards;
        }
    }
}
