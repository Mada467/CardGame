using System;

namespace BlackJack_Game
{
    public class Dealer : Player
    {
        // Constructor specific dealer-ului
        public Dealer() : base("Dealer") { }

        // Suprascrierea metodei AddCard
        public override void AddCard(Card card)
        {
            base.AddCard(card); // Apelează metoda din clasa de bază
            if (Hand.Count == 1)
            {
                Console.WriteLine("Dealer's first card is hidden."); // Dealer-ul ascunde prima carte
            }
        }

        // Metodă pentru a dezvălui toate cărțile dealer-ului
        public void RevealHand()
        {
            Console.WriteLine("Dealer reveals their hand:");
            //ShowHand();
        }
    }
}
