using BlackJack_Client.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace BlackJack_Client
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
            Image[,] images =
            {
                {
                    Resources.cardClubsA, Resources.cardClubs2, Resources.cardClubs3, Resources.cardClubs4, Resources.cardClubs5, Resources.cardClubs6, Resources.cardClubs7, Resources.cardClubs8, Resources.cardClubs9, Resources.cardClubs10,
                    Resources.cardClubsJ, Resources.cardClubsQ, Resources.cardClubsK
                },
                {
                    Resources.cardDiamondsA, Resources.cardDiamonds2, Resources.cardDiamonds3, Resources.cardDiamonds4, Resources.cardDiamonds5, Resources.cardDiamonds6, Resources.cardDiamonds7, Resources.cardDiamonds8, Resources.cardDiamonds9, Resources.cardDiamonds10,
                    Resources.cardDiamondsJ, Resources.cardDiamondsQ, Resources.cardDiamondsK
                },
                {
                    Resources.cardHeartsA, Resources.cardHearts2, Resources.cardHearts3, Resources.cardHearts4, Resources.cardHearts5, Resources.cardHearts6, Resources.cardHearts7, Resources.cardHearts8, Resources.cardHearts9, Resources.cardHearts10,
                    Resources.cardHeartsJ, Resources.cardHeartsQ, Resources.cardHeartsK
                },
                {
                    Resources.cardSpadesA, Resources.cardSpades2, Resources.cardSpades3, Resources.cardSpades4, Resources.cardSpades5, Resources.cardSpades6, Resources.cardSpades7, Resources.cardSpades8, Resources.cardSpades9, Resources.cardSpades10,
                    Resources.cardSpadesJ, Resources.cardSpadesQ, Resources.cardSpadesK
                },
            };

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
