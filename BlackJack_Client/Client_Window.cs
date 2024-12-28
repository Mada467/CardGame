using BlackJack_Client.Properties;
using System;
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
        private GameClient game; // Instanța jocului
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

        private int playerCardCounter = 0;
        private int dealerCardCounter = 0;

        private PictureBox[] playerPictureBoxes = new PictureBox[3];
        private PictureBox[] dealerPictureBoxes = new PictureBox[3];

        public Client_Window()
        {
            InitializeComponent(); // Inițializează componentele formularului
            playerPictureBoxes[0] = playerFirstCardImg;
            playerPictureBoxes[1] = playerSecondCardImg;
            playerPictureBoxes[2] = playerThirdCardImg;
            dealerPictureBoxes[0] = dealerFirstCardImg;
            dealerPictureBoxes[1] = dealerSecondCardImg;
            dealerPictureBoxes[2] = dealerThirdCardImg;
            game = new GameClient();     // Creăm jocul
        }

        // Eveniment pentru butonul "Start Game"
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            game.StartGame(); // Pornește jocul
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
                connect_Btn.Text = "Connect";
            }
        }

        private void Client_Window_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Card card = game.DrawNewCard();
            playerPictureBoxes[playerCardCounter].Image = images[card.Suit - 1, card.Rank - 1];
            SendInstructions(card.Suit + " " + card.Rank);
            playerCardCounter++;
        }

        public void ExecuteInstructions(string dateServer)
        {
            string[] parts = dateServer.Split(' ');
            dealerPictureBoxes[dealerCardCounter].Image = images[Convert.ToInt32(parts[0]) - 1, Convert.ToInt32(parts[1]) - 1];
            dealerCardCounter++;
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

