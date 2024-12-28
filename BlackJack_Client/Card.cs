namespace BlackJack_Client
{
    public class Card
    {
        // Suit-ul (culoarea) cărții, ex: "Hearts", "Diamonds"
        public int Suit { get; private set; }

        // Rangul cărții, ex: "Ace", "King", "2"
        public int Rank { get; private set; }

        // Constructor pentru a inițializa o carte cu Suit, Rank și Value
        public Card(int suit, int rank)
        {
            Suit = suit;
            Rank = rank;
        }

        // Suprascrierea metodei ToString pentru a returna o reprezentare text a cărții
        public override string ToString()
        {
            string card = Rank.ToString() + " of " + Suit.ToString(); // Ex: "Ace of Hearts" --- mai adaugi aici ce mai vrei sa afisezi

            return card;
        }
    }
}
