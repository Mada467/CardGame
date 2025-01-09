using BlackJack_Server.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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


        private PictureBox[] playerPictureBoxes = new PictureBox[5];
        private PictureBox[] dealerPictureBoxes = new PictureBox[5];

        private Image firstCardImage = null;

        public Server_Window()
        {
            InitializeComponent(); // Inițializează componentele formularului

            deck = new Deck();         // Creăm un pachet nou
            player = new Player(); // Inițializăm jucătorul
            dealer = new Dealer();     // Inițializăm dealer-ul

            playerPictureBoxes[0] = playerCardImg1;
            playerPictureBoxes[1] = playerCardImg2;
            playerPictureBoxes[2] = playerCardImg3;
            playerPictureBoxes[3] = playerCardImg4;
            playerPictureBoxes[4] = playerCardImg5;
            dealerPictureBoxes[0] = dealerCardImg1;
            dealerPictureBoxes[1] = dealerCardImg2;
            dealerPictureBoxes[2] = dealerCardImg3;
            dealerPictureBoxes[3] = dealerCardImg4;
            dealerPictureBoxes[4] = dealerCardImg5;

            for (int i = 0; i < 5; i++)
            {
                playerPictureBoxes[i].Visible = false;
                dealerPictureBoxes[i].Visible = false;
            }

            server = new TcpListener(System.Net.IPAddress.Any, 8098);
            server.Start();
            t = new Thread(new ThreadStart(Asculta_Server));
            workThread = true;

            t.Start();
        }

        // Calculează scorul total pe baza mâinii jucătorului
        public int CalculateScore(Player player)
        {
            int score = 0;     // Scorul inițial
            int aceCount = 0;  // Numărul de Ași din mână

            // Adăugăm valoarea fiecărei cărți la scor
            foreach (var card in player.GetPlayerHand())
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
        // Verificăm cine a câștigat jocul
        private bool PlayerIsBusted()
        {
            bool status = false;
            if (player.GetScore() > 21)
            {
                statusMessage.Text = "YOU WON!";
                statusMessage.ForeColor = Color.Black;
                status = true;
            }
            return status;
        }

        private bool PlayerHasReachedMaxScore()
        {
            bool status = false;
            if (player.GetScore() == 21)
            {
                statusMessage.Text = "YOU LOST!"; 
                statusMessage.ForeColor = Color.Black;
                status = true;
            }
            return status;
        }

        private void DetermineWinner()
        {
            RevealDealerCard();
            if (dealer.GetScore() == 21)
            {
                statusMessage.Text = "YOU WON!";
                statusMessage.ForeColor = Color.Red;
            }
            if (dealer.GetScore() > 21)
            {
                statusMessage.Text = "BUSTED!";
                statusMessage.ForeColor = Color.Red;
            }
            if (dealer.GetScore() > player.GetScore())
            {
                statusMessage.Text = "YOU WON!";
                statusMessage.ForeColor = Color.Black;
            }
            else
            {
                statusMessage.Text = "YOU LOST!";
                statusMessage.ForeColor = Color.Red;
            }
            determineWinnerBtn.Enabled = false;
        }

        private void RevealDealerCard()
        {
            dealerPictureBoxes[0].Image = firstCardImage;
        }

        public Card DrawNewCard(Player player)
        {
            Card card = deck.DrawCard();
            player.AddCard(card);
            return card;
        }

        private void drawCard_Click(object sender, EventArgs e)
        {
            Card card = DrawNewCard(dealer);
            if (dealer.GetIsCurrentCardHidden() == true)
            {
                firstCardImage = images[card.Suit - 1, card.Rank - 1];
                dealerPictureBoxes[dealerCardCounter].Image = Resources.cardBack;
            }
            else
            {
                dealerPictureBoxes[dealerCardCounter].Image = images[card.Suit - 1, card.Rank - 1];
            }
            dealerPictureBoxes[dealerCardCounter].Visible = true;
            dealerPictureBoxes[dealerCardCounter].BringToFront();
            SendInstructions(2 + " " + card.Suit + " " + card.Rank);
            dealerCardCounter++;
            dealer.SetScore(CalculateScore(dealer));
            dealerScoreLabel.Text = "Score:" + dealer.GetScore();
            if (PlayerIsBusted() || PlayerHasReachedMaxScore())
            {
                determineWinnerBtn.Enabled = false;
            }
        }

        public void ExecuteInstructions(string dateClient)
        {
            string[] parts = dateClient.Split(' ');
            if (Convert.ToInt32(parts[0]) == 3)
            {
                DetermineWinner();
            }
            else
            {
                if (Convert.ToInt32(parts[0]) == 0)
                {
                    Card card = DrawNewCard(player);
                    playerPictureBoxes[playerCardCounter].Image = images[card.Suit - 1, card.Rank - 1];
                    playerPictureBoxes[playerCardCounter].Visible = true;
                    playerPictureBoxes[playerCardCounter].BringToFront();
                    SendInstructions(1 + " " + card.Suit + " " + card.Rank);
                    playerCardCounter++;
                    player.SetScore(CalculateScore(player));
                    playerScoreLabel.Text = "Score:" + player.GetScore();
                }
                if (PlayerIsBusted() || PlayerHasReachedMaxScore())
                {
                    determineWinnerBtn.Enabled = false;
                }
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

        private void determineWinnerBtn_Click(object sender, EventArgs e)
        {
            DetermineWinner();
            SendInstructions("3");
        }
    }
}

