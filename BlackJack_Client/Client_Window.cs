using BlackJack_Client.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Threading;
using System.Windows.Forms;

namespace BlackJack_Client
{
    public partial class Client_Window : Form
    {
        private bool isConnected = false;
        private string ipAddress;

        public TcpClient client;
        public NetworkStream clientStream;
        public bool ascult;
        public Thread t;

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

        private Player player; // Jucătorul
        private Dealer dealer; // Dealer-ul
        private int playerCardCounter = 0;
        private int dealerCardCounter = 0;

        private PictureBox[] playerPictureBoxes = new PictureBox[3];
        private PictureBox[] dealerPictureBoxes = new PictureBox[3];

        public Client_Window()
        {
            InitializeComponent(); // Inițializează componentele formularului

            player = new Player(); // Inițializăm jucătorul
            dealer = new Dealer();     // Inițializăm dealer-ul

            playerPictureBoxes[0] = playerFirstCardImg;
            playerPictureBoxes[1] = playerSecondCardImg;
            playerPictureBoxes[2] = playerThirdCardImg;
            dealerPictureBoxes[0] = dealerFirstCardImg;
            dealerPictureBoxes[1] = dealerSecondCardImg;
            dealerPictureBoxes[2] = dealerThirdCardImg;
            drawCardBtn.Enabled = false;
        }

        // Calculează scorul total pe baza mâinii jucătorului
        public int CalculateScore(object obj)
        {
            int score = 0;     // Scorul inițial
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

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            ipAddress = ipAddress_Tb.Text;

            if (isConnected == false)
            {
                if (ipAddress.Length > 0)
                {
                    ConnectToServer(ipAddress);
                    isConnected = true;
                    ipAddress_Tb.Enabled = false;
                    drawCardBtn.Enabled = true;
                    connect_Btn.Text = "Disconnect";
                }
                else
                {
                    MessageBox.Show("Specificati adresa de IP");
                }
            }
            else
            {
                DisconnectFromServer();
                isConnected = false;
                ipAddress_Tb.Enabled = true;
                drawCardBtn.Enabled = false;
                connect_Btn.Text = "Connect";
            }
        }

        private void Client_Window_Load(object sender, EventArgs e)
        {

        }

        private void drawCard_Click(object sender, EventArgs e)
        {
            SendInstructions(0 + " " + 0 + " " + 0); // 0 0 este comanda care cere o carte la server

            /*Card card = game.DrawNewCard();*/

        }

        public void ExecuteInstructions(string dateServer)
        {
            string[] parts = dateServer.Split(' ');
            int playerScore = 0;
            int dealerScore = 0;
            Card card = new Card(Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]));
            if (Convert.ToInt32(parts[0]) == 1) //primire carte pentru player
            {
                player.AddCard(card);
                playerPictureBoxes[playerCardCounter].Image = images[Convert.ToInt32(parts[1]) - 1, Convert.ToInt32(parts[2]) - 1];
                playerCardCounter++;
                playerScore = CalculateScore(player);
                playerScoreLabel.Text = "Score:" + playerScore;
            }
            else if (Convert.ToInt32(parts[0]) == 2) //primire carte pentru dealer
            {
                dealer.AddCard(card);
                dealerPictureBoxes[dealerCardCounter].Image = images[Convert.ToInt32(parts[1]) - 1, Convert.ToInt32(parts[2]) - 1];
                dealerCardCounter++;
                dealerScore = CalculateScore(dealer);
                dealerScoreLabel.Text = "Score:" + dealerScore;
            }
        }

        private void Asculta_client()
        {
            StreamReader citire = new StreamReader(clientStream);
            String dateClient;
            while (ascult)
            {
                dateClient = citire.ReadLine();
                MethodInvoker m = new MethodInvoker(() => ExecuteInstructions(dateClient));
                this.Invoke(m);
            }
        }

        private void SendInstructions(string clientInstructions)
        {
            try
            {
                StreamWriter scriere = new StreamWriter(clientStream);
                scriere.AutoFlush = true; // enable automatic flushing

                scriere.WriteLine(clientInstructions);
            }
            finally
            {

            }
        }

        public void ConnectToServer(string ipAddress)
        {
            client = new TcpClient(ipAddress, 8098);
            ascult = true;
            t = new Thread(new ThreadStart(Asculta_client));
            t.Start();
            clientStream = client.GetStream();
        }

        public void DisconnectFromServer()
        {
            ascult = false;
            t.Abort();
            StreamWriter scriere = new StreamWriter(clientStream);
            scriere.AutoFlush = true; // enable automatic flushing
            scriere.WriteLine("#Gata");
        }

    }
}

