using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Player
    {
        protected string Name { get; private set; } // Numele jucătorului
        protected List<Card> Hand; // Lista cărților din mână

        public List<Card> GetHand()
        { 
            return Hand;
        }


        // Constructor pentru inițializarea jucătorului
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        // Metodă virtuală pentru adăugarea unei cărți
        public virtual void AddCard(Card card)
        {
            Hand.Add(card); // Adaugă cartea în mână
            Console.WriteLine($"{Name} received {card}");
        }

        // Calculează scorul jucătorului
        public int GetScore()
        {
            int score = 0; // Totalul punctelor
            int aceCount = 0; // Numărul de ași

            foreach (var card in Hand)
            {
                score += card.Points; // Adaugă punctele fiecărei cărți
                if (card.Value == "Ace")
                    aceCount++; // Contorizează așii
            }

            // Ajustează valoarea pentru așii care depășesc 21
            while (score > 21 && aceCount > 0)
            {
                score -= 10; // Reduce valoarea unui as la 1
                aceCount--;
            }

            return score;
        }

        // Afișează cărțile din mână și scorul
        public void ShowHand()
        {
            Console.WriteLine($"{Name}'s hand:");
            foreach (var card in Hand)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine($"Score: {GetScore()}");
        }
    }
}
