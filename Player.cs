using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{


    public class Player
    {
        // Numele jucătorului (ex: "Player", "Dealer")
        public string Name { get; private set; }

        // Lista de cărți din mână
        protected List<Card> Hand = new List<Card>();

        // Scorul jucătorului calculat din cărțile din mână
        public int Score => CalculateScore();

        // Constructor pentru a inițializa jucătorul cu un nume
        public Player(string name)
        {
            Name = name;
        }

        // Adaugă o carte în mâna jucătorului
        public virtual void AddCard(Card card)
        {
            Hand.Add(card);
        }

        // Determină dacă jucătorul dorește să tragă o altă carte (poate fi suprascris)
        public virtual bool WantsToDraw()
        {
            return Score < 17; // De obicei, jucătorul trage dacă scorul este sub 17
        }

        // Calculează scorul total pe baza mâinii jucătorului
        private int CalculateScore()
        {
            int score = 0;     // Scorul inițial
            int aceCount = 0;  // Numărul de Ași din mână

            // Adăugăm valoarea fiecărei cărți la scor
            foreach (var card in Hand)
            {
                score += card.Value;

                // Numărăm Așii pentru ajustarea ulterioară a scorului
                if (card.Rank == "Ace") aceCount++;
            }

            // Dacă scorul depășește 21, reducem valoarea Așilor de la 11 la 1
            while (score > 21 && aceCount > 0)
            {
                score -= 10; // Scădem 10 pentru fiecare As
                aceCount--;
            }

            return score; // Returnăm scorul calculat
        }

        // Reprezentare text a mâinii și scorului
        public override string ToString()
        {
            return $"{Name}: {string.Join(", ", Hand)} (Score: {Score})";
        }
    }
}

