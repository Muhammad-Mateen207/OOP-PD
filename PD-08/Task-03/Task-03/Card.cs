using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TASK_2
{
    class Card
    {
        private int value;
        private int suit;

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public int GetBlackJackValue()
        {
            if (value > 10) return 10;
            if (value == 1) return 11; // Ace default as 11
            return value;
        }

        public int GetRawValue() => value;

        public string GetValueAsString()
        {
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }

        public string GetSuitAsString()
        {
            if (suit == 1) return "Clubs";
            if (suit == 2) return "Diamonds";
            if (suit == 3) return "Spades";
            return "Hearts";
        }

        public override string ToString() => $"{GetValueAsString()} of {GetSuitAsString()}";
    }
}
