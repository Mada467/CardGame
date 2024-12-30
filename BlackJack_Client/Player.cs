using System.Collections.Generic;

namespace BlackJack_Client
{
    public class Player
    {
        // Lista de cărți din mână
        protected List<Card> hand = new List<Card>();

        protected int score;

        public void SetScore(int score)
        {
            this.score = score;
        }

        public int GetScore()
        {
            return score;
        }

        public List<Card> GetPlayerHand()
        {
            return hand;
        }

        // Constructor pentru a inițializa jucătorul cu un nume
        public Player()
        {
            score = 0;
        }

        // Adaugă o carte în mâna jucătorului
        public virtual void AddCard(Card card)
        {
            hand.Add(card);
        }
    }
}

