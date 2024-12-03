using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        private List<Card> cards; // Lista care stochează toate cărțile
        private static readonly string[] Suits = { "Hearts", "Diamonds", "Clubs", "Spades" }; // Culorile cărților
        private static readonly string[] Values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" }; // Valorile cărților
        private static readonly int[] Points = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 }; // Punctele asociate fiecărei valori

        // Constructor care creează pachetul de cărți
        public Deck()
        {
            cards = new List<Card>();
            // Populează lista cu toate cărțile
            for (int i = 0; i < Suits.Length; i++)
            {
                for (int j = 0; j < Values.Length; j++)
                {
                    cards.Add(new Card(Suits[i], Values[j], Points[j]));
                }
            }
        }

        // Metodă pentru amestecarea cărților
        public void Shuffle()
        {
            Random rng = new Random();
            for (int i = cards.Count - 1; i > 0; i--)  //rng =random nnumber generate
            {
                int j = rng.Next(i + 1);
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        // Metodă pentru extragerea unei cărți din pachet
        public Card Draw()
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("No more cards in the deck."); // Aruncă eroare dacă nu mai sunt cărți

            var card = cards[0]; // Extrage prima carte
            cards.RemoveAt(0);  // Elimină cartea din pachet
            return card;
        }
    }
}
