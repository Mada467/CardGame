using BlackJack_Server.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BlackJack_Server
{
    public partial class Server_Window : Form
    {
        public TcpListener server;
        public String dateServer;
        Thread t;
        bool workThread;
        NetworkStream streamServer;

        private Image[,] images =
        {
            {
                Resources.cardClubsA, Resources.cardClubs2, Resources.cardClubs3, Resources.cardClubs4, Resources.cardClubs5, Resources.cardClubs6, Resources.cardClubs7, Resources.cardClubs8, Resources.cardClubs9, Resources.cardClubs10,
                Resources.cardClubsJ, Resources.cardClubsQ, Resources.cardClubsK
            },
            {
                Resources.cardDiamondsA, Resources.cardDiamonds2, Resources.cardDiamonds3, Resources.cardDiamonds4, Resources.cardDiamonds5, Resources.cardDiamonds6, Resources.cardDiamonds7, Resources.cardDiamonds8, Resources.cardDiamonds9, Resources.cardDiamonds10,
                Resources.cardDiamondsJ, Resources.cardDiamondsQ, Resources.cardDiamondsK
            },
            {
                Resources.cardHeartsA, Resources.cardHearts2, Resources.cardHearts3, Resources.cardHearts4, Resources.cardHearts5, Resources.cardHearts6, Resources.cardHearts7, Resources.cardHearts8, Resources.cardHearts9, Resources.cardHearts10,
                Resources.cardHeartsJ, Resources.cardHeartsQ, Resources.cardHeartsK
            },
            {
                Resources.cardSpadesA, Resources.cardSpades2, Resources.cardSpades3, Resources.cardSpades4, Resources.cardSpades5, Resources.cardSpades6, Resources.cardSpades7, Resources.cardSpades8, Resources.cardSpades9, Resources.cardSpades10,
                Resources.cardSpadesJ, Resources.cardSpadesQ, Resources.cardSpadesK
            },
        };

        private int playerCardCounter = 0;
        private int dealerCardCounter = 0;
        private Deck deck;    // Pachetul de cărți
        private Player player; // Jucătorul
        private Dealer dealer; // Dealer-ul


        private PictureBox[] playerPictureBoxes = new PictureBox[3];
        private PictureBox[] dealerPictureBoxes = new PictureBox[3];

        public Server_Window()
        {
            InitializeComponent(); // Inițializează componentele formularului

            deck = new Deck();         // Creăm un pachet nou
            player = new Player(); // Inițializăm jucătorul
            dealer = new Dealer();     // Inițializăm dealer-ul

            playerPictureBoxes[0] = playerFirstCardImg;
            playerPictureBoxes[1] = playerSecondCardImg;
            playerPictureBoxes[2] = playerThirdCardImg;
            dealerPictureBoxes[0] = dealerFirstCardImg;
            dealerPictureBoxes[1] = dealerSecondCardImg;
            dealerPictureBoxes[2] = dealerThirdCardImg;

            server = new TcpListener(System.Net.IPAddress.Any, 8098);
            server.Start();
            t = new Thread(new ThreadStart(Asculta_Server));
            workThread = true;

            t.Start();
        }

        // Calculează scorul total pe baza mâinii jucătorului
        public int CalculateScore(object obj)
        {
            int score = 0;     // Scorul inițial
            int aceCount = 0;  // Numărul de Ași din mână
            List<Card> hand = new List<Card>();

            if (obj is Player)
            {
                hand = player.GetPlayerHand();
            }
            else if (obj is Dealer)
            {
                hand = dealer.GetPlayerHand();
            }

            // Adăugăm valoarea fiecărei cărți la scor
            foreach (var card in hand)
            {
                if (card.Rank > 10)
                {
                    score += 10;
                }
                else if (card.Rank == 1)
                {
                    if (score + 11 <= 21)
                    {
                        score += 11;
                    }
                    else
                    {
                        score += 1;
                    }
                }
                else
                {
                    score += card.Rank;
                }

                // Numărăm Așii pentru ajustarea ulterioară a scorului
                if (card.Rank == 1) aceCount++;
            }

            // Dacă scorul depășește 21, reducem valoarea Așilor de la 11 la 1
            while (score > 21 && aceCount > 0)
            {
                score -= 10; // Scădem 10 pentru fiecare As
                aceCount--;
            }

            return score; // Returnăm scorul calculat
        }

        // Verificăm cine a câștigat jocul
        private void DetermineWinner()
        {
            if (player.GetScore() > 21)
                Console.WriteLine("Player busts! Dealer wins.");
            else if (dealer.GetScore() > 21 || player.GetScore() > dealer.GetScore())
                Console.WriteLine("Player wins!");
            else if (dealer.GetScore() > player.GetScore())
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

        private void drawCard_Click(object sender, EventArgs e)
        {
            Card card = DrawNewCard();
            dealerPictureBoxes[dealerCardCounter].Image = images[card.Suit - 1, card.Rank - 1];
            SendInstructions(2 + " " + card.Suit + " " + card.Rank);
            dealerCardCounter++;
        }

        public void ExecuteInstructions(string dateClient)
        {
            string[] parts = dateClient.Split(' ');
            if (Convert.ToInt32(parts[0]) == 0)
            {
                Card card = DrawNewCard();
                playerPictureBoxes[playerCardCounter].Image = images[card.Suit - 1, card.Rank - 1];
                SendInstructions(1 + " " + card.Suit + " " + card.Rank);
                playerCardCounter++;
            }
            else
            {

            }
        }

        public void Asculta_Server()
        {

            while (workThread)
            {
                Socket socketServer = server.AcceptSocket();
                try
                {
                    streamServer = new NetworkStream(socketServer);
                    StreamReader citireServer = new StreamReader(streamServer);

                    while (workThread)
                    {

                        String dateServer = citireServer.ReadLine();
                        if (dateServer == null) break;//primesc nimic - clientul a plecat
                        if (dateServer == "#Gata") //ca sa pot sa inchid serverul
                            workThread = false;
                        MethodInvoker m = new MethodInvoker(() => ExecuteInstructions(dateServer));
                        this.Invoke(m);
                    }
                    streamServer.Close();
                }
                catch (Exception e)
                {
#if LOG
                    Console.WriteLine(e.Message);
#endif
                }
                socketServer.Close();
            }

        }

        private void SendInstructions(string serverInstructions)
        {
            try
            {
                StreamWriter scriere = new StreamWriter(streamServer);
                scriere.AutoFlush = true; // enable automatic flushing
                scriere.WriteLine(serverInstructions);
            }
            finally
            {

            }
        }
    }
}

