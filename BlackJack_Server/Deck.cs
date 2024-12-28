using BlackJack_Server.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace BlackJack_Server
{
    public class Deck
    {
        // Lista care conține toate cărțile din pachet
        private List<Card> cards = new List<Card>();

        // Generator de numere aleatoare pentru amestecarea pachetului
        private Random random = new Random();

        private int numberOfSuits = 4;

        private int numberOfRanks = 13;

        // Constructor pentru inițializarea unui pachet complet de cărți
        public Deck()
        {
            // Generăm toate combinațiile posibile de Suit, Rank și Value
            for (int i = 1; i <= numberOfSuits; i++)
            {
                for (int j = 1; j <= numberOfRanks; j++)
                {
                    cards.Add(new Card(i, j));
                }
            }
        }

        // Metoda pentru extragerea unei cărți aleatoare din pachet
        public Card DrawCard()
        {
            int index = random.Next(cards.Count); // Selectăm o carte la întâmplare
            Card card = cards[index];            // Salvăm cartea selectată
            cards.RemoveAt(index);               // Scoatem cartea din pachet
            return card;                         // Returnăm cartea extrasă
        }
    }
}
