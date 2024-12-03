namespace BlackJack_Game
{
    public class Card
    {
        // Suit-ul (culoarea) cărții, ex: "Hearts", "Diamonds"
        public string Suit { get; private set; }

        // Rangul cărții, ex: "Ace", "King", "2"
        public string Rank { get; private set; }

        // Valoarea cărții (utilizată pentru calcularea scorului)
        public int Value { get; private set; }

        // Constructor pentru a inițializa o carte cu Suit, Rank și Value
        public Card(string suit, string rank, int value)
        {
            Suit = suit;
            Rank = rank;
            Value = value;
        }

        // Suprascrierea metodei ToString pentru a returna o reprezentare text a cărții
        public override string ToString()
        {
            string card = Rank.ToString() + " of " + Suit.ToString(); // Ex: "Ace of Hearts" --- mai adaugi aici ce mai vrei sa afisezi

            return card;
        }
    }
}
