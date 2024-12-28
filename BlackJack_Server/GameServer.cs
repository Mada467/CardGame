using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace BlackJack_Server
{
    public class GameServer
    {
        private Deck deck;    // Pachetul de cărți
        private Player player; // Jucătorul
        private Dealer dealer; // Dealer-ul

        // Constructor pentru inițializarea jocului
        public GameServer()
        {
            deck = new Deck();         // Creăm un pachet nou
            player = new Player("Player"); // Inițializăm jucătorul
            dealer = new Dealer();     // Inițializăm dealer-ul
        }

        // Începe jocul
        public void StartGame()
        {
            // Fiecare jucător trage inițial 2 cărți
            player.AddCard(deck.DrawCard());
            player.AddCard(deck.DrawCard());

            // Dealer-ul trage o carte
            dealer.AddCard(deck.DrawCard());

            // Afișăm starea inițială a jocului
            Console.WriteLine(player);
            Console.WriteLine(dealer);

            // Jucătorul continuă să tragă cărți până se oprește
            while (player.WantsToDraw())
            {
                player.AddCard(deck.DrawCard());
                Console.WriteLine(player);
            }

            // Dealer-ul continuă să tragă cărți după reguli
            while (dealer.WantsToDraw())
            {
                dealer.AddCard(deck.DrawCard());
                Console.WriteLine(dealer);
            }

            // Determinăm câștigătorul
            DetermineWinner();
        }

        // Verificăm cine a câștigat jocul
        private void DetermineWinner()
        {
            if (player.Score > 21)
                Console.WriteLine("Player busts! Dealer wins.");
            else if (dealer.Score > 21 || player.Score > dealer.Score)
                Console.WriteLine("Player wins!");
            else if (dealer.Score > player.Score)
                Console.WriteLine("Dealer wins!");
            else
                Console.WriteLine("It's a tie!");
        }

        public Card DrawNewCard()
        {
            Card card = deck.DrawCard();
            player.AddCard(card);
            return card;
        }
    }
}

