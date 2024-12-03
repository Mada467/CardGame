using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{ 
    public class Card
    {
        // Suit - reprezintă culoarea (Hearts, Diamonds, etc.)
        public string Suit { get; private set; }

        // Value - reprezintă valoarea (2, 3, King, Ace, etc.)
        public string Value { get; private set; }

        // Points - punctele asociate valorii cărții
        public int Points { get; private set; }

        // Constructor pentru inițializarea cărților
        public Card(string suit, string value, int points)
        {
            Suit = suit;
            Value = value;
            Points = points;
        }

        // Metodă pentru afișarea informațiilor despre carte
        public override string ToString()
        {
            return Value.ToString() + " of " + Suit.ToString();//conversie din int in string
        }
        
        
    }
}
