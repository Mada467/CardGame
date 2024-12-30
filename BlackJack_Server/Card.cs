namespace BlackJack_Server
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
    }
}
