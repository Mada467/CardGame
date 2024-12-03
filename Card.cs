using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card
    {
        // Suit-ul (culoarea) cărții, ex: "Hearts", "Diamonds"
        public string Suit { get; private set; }

        // Rangul cărții, ex: "Ace", "King", "2"
        public string Rank { get; private set; }

        // Valoarea cărții (utilizată pentru calcularea scorului)
        public int Value { get; private set; }

        // Constructor pentru a inițializa o carte cu Suit, Rank și Value
        public Card(string suit, string rank, int value)
        {
            Suit = suit;
            Rank = rank;
            Value = value;
        }

        // Suprascrierea metodei ToString pentru a returna o reprezentare text a cărții
        public override string ToString()
        {
            return $"{Rank} of {Suit}"; // Ex: "Ace of Hearts"
        }
    }


}
