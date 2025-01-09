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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private PictureBox[] playerPictureBoxes = new PictureBox[5];
        private PictureBox[] dealerPictureBoxes = new PictureBox[5];

        private Image firstCardImage = null;

        public Client_Window()
        {
            InitializeComponent(); // Inițializează componentele formularului

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
            drawCardBtn.Enabled = false;
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
        private bool PlayerIsBusted()
        {
            bool status = false;
            if (player.GetScore() > 21)
            {
                statusMessage.Text = "BUSTED!";
                statusMessage.ForeColor = Color.Red;
                status = true;
            }
            return status;
        }

        private bool PlayerHasReachedMaxScore()
        {
            bool status = false;
            if (player.GetScore() == 21)
            {
                statusMessage.Text = "YOU WON!";
                statusMessage.ForeColor = Color.Red;
                status = true;
            }
            return status;
        }

        private void DetermineWinner()
        {
            RevealDealerCard();
            if (dealer.GetScore() > 21)
            {
                statusMessage.Text = "YOU WON!";
                statusMessage.ForeColor = Color.Black;
            }
            if (dealer.GetScore() == 21)
            {
                statusMessage.Text = "YOU LOST!";
                statusMessage.ForeColor = Color.Black;
            }
            if (player.GetScore() > dealer.GetScore())
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
            SendInstructions("0"); // 0 0 este comanda care cere o carte la server
        }

        public void ExecuteInstructions(string dateServer)
        {
            string[] parts = dateServer.Split(' ');
            Card card = new Card(Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]));
            if (Convert.ToInt32(parts[0]) == 3)
            {
                DetermineWinner();
            }
            else
            {
                if (Convert.ToInt32(parts[0]) == 1) //primire carte pentru player
                {
                    player.AddCard(card);
                    playerPictureBoxes[playerCardCounter].Image = images[Convert.ToInt32(parts[1]) - 1, Convert.ToInt32(parts[2]) - 1];
                    playerPictureBoxes[playerCardCounter].Visible = true;
                    playerPictureBoxes[playerCardCounter].BringToFront();
                    playerCardCounter++;
                    player.SetScore(CalculateScore(player));
                    playerScoreLabel.Text = "Score:" + player.GetScore();
                }
                else if (Convert.ToInt32(parts[0]) == 2) //primire carte pentru dealer
                {
                    dealer.AddCard(card);
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
                    dealerCardCounter++;
                    dealer.SetScore(CalculateScore(dealer));
                    dealerScoreLabel.Text = "Score:" + dealer.GetScore();
                }
                if (PlayerIsBusted() || PlayerHasReachedMaxScore())
                {
                    determineWinnerBtn.Enabled = false;
                }
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

        private void determineWinnerBtn_Click(object sender, EventArgs e)
        {
            DetermineWinner();
            SendInstructions("3");
        }
    }
}

