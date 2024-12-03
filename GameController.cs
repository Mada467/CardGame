using CardGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class GameController
    {

        private Deck deck;
        private Player player;
        private Dealer dealer;
        

        public Image CardImage { get; private set; }

        public GameController()
        {
            // Creează pachetul de cărți
            deck = new Deck();
            
            // Creează jucătorul și dealer-ul
            player = new Player("Player");
            dealer = new Dealer();

            
        }
            
        public List<Card> StartGame ()
        {
            // Amestecă pachetul de cărți
            deck.Shuffle();

            // Distribuie două cărți fiecărui jucător
            player.AddCard(deck.Draw());
            player.AddCard(deck.Draw());
            dealer.AddCard(deck.Draw());
            dealer.AddCard(deck.Draw());

            return player.GetHand();

        }

      

        

        //// Afișează mâna jucătorului
        //player.ShowHand();

        //// Afișează mâna dealer-ului (parțial ascunsă)
        //dealer.ShowHand();

        //// Logica pentru turul jucătorului
        //while (player.GetScore() < 21)
        //{
        //    Console.Write("Do you want to hit or stand? (h/s): ");
        //    var choice = Console.ReadLine();
        //    if (choice.ToLower() == "h")
        //    {
        //        player.AddCard(deck.Draw());
        //        player.ShowHand();
        //    }
        //    else
        //    {
        //        break; // Jucătorul a ales să "stea"
        //    }
        //}

        //// Dealer-ul își dezvăluie mâna
        //dealer.RevealHand();

        //// Logica dealer-ului (trage cărți până la minim 17 puncte)
        //while (dealer.GetScore() < 17)
        //{
        //    dealer.AddCard(deck.Draw());
        //}

        //// Afișează mâna finală a dealer-ului
        //dealer.ShowHand();

        //// Determinarea câștigătorului
        //int playerScore = player.GetScore();
        //int dealerScore = dealer.GetScore();

        //// Verifică rezultatul jocului
        //if (playerScore > 21)
        //{
        //    Console.WriteLine("You busted! Dealer wins.");
        //}
        //else if (dealerScore > 21 || playerScore > dealerScore)
        //{
        //    Console.WriteLine("You win!");
        //}
        //else if (playerScore < dealerScore)
        //{
        //    Console.WriteLine("Dealer wins.");
        //}
        //else
        //{
        //    Console.WriteLine("It's a tie!");
        //}
    }
}
