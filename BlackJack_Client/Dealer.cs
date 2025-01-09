using System;

namespace BlackJack_Client
{
    public class Dealer : Player
    {
        private bool isCurrentCardHidden;

        public bool GetIsCurrentCardHidden()
        {
            return isCurrentCardHidden;
        }

        // Constructor specific dealer-ului
        public Dealer() : base() { }

        // Suprascrierea metodei AddCard
        public override void AddCard(Card card)
        {
            base.AddCard(card); // Apelează metoda din clasa de bază
            if (hand.Count == 1)
            {
                isCurrentCardHidden = true; // Dealer-ul ascunde prima carte
            }
            else
            {
                isCurrentCardHidden = false;
            }
        }
    }
}
