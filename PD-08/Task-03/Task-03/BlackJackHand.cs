using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    class BlackJackHand : Hand
    {
        public int GetHandValue()
        {
            int total = 0;
            int aceCount = 0;

            foreach (Card card in cards)
            {
                int val = card.GetBlackJackValue();
                total += val;
                if (val == 11) aceCount++;
            }

            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }

        public bool IsBusted()
        {
            return GetHandValue() > 21;
        }

        public void AutoPlayDealer(Deck deck)
        {
            while (GetHandValue() < 17)
            {
                AddCard(deck.DealCard());
            }
        }
    }
}
