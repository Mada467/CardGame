namespace BlackJack_Client
{
    using System;
    using System.Collections.Generic;

    public class Deck
    {
        // Lista care conține toate cărțile din pachet
        private List<Card> cards = new List<Card>();

        // Generator de numere aleatoare pentru amestecarea pachetului
        private Random random = new Random();

        // Constructor pentru inițializarea unui pachet complet de cărți
        public Deck()
        {
            // Definirea suit-urilor (culorilor)
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            // Definirea rangurilor (valorilor nominale)
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            // Valoarea fiecărui rang în joc
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

            // Generăm toate combinațiile posibile de Suit, Rank și Value
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    cards.Add(new Card(suits[i], ranks[j], values[j]));
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
