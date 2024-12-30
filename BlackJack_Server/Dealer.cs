using System;

namespace BlackJack_Server
{
    public class Dealer : Player
    {
        // Constructor specific dealer-ului
        public Dealer() : base() { }

        // Suprascrierea metodei AddCard
        public override void AddCard(Card card)
        {
            base.AddCard(card); // Apelează metoda din clasa de bază
            if (hand.Count == 1)
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
