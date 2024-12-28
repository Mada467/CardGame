using BlackJack_Server.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace BlackJack_Server
{
    public partial class Server_Window : Form
    {
        private GameServer game; // Instanța jocului

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

        private PictureBox[] playerPictureBoxes = new PictureBox[3];
        private PictureBox[] dealerPictureBoxes = new PictureBox[3];

        public Server_Window()
        {
            InitializeComponent(); // Inițializează componentele formularului
            game = new GameServer();     // Creăm jocul

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

        // Eveniment pentru butonul "Start Game"
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            game.StartGame(); // Pornește jocul
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Card card = game.DrawNewCard();
            dealerPictureBoxes[dealerCardCounter].Image = images[card.Suit - 1, card.Rank - 1];
            SendInstructions(card.Suit + " " + card.Rank);
            dealerCardCounter++;
        }

        public void ExecuteInstructions(string dateClient)
        {
            string[] parts = dateClient.Split(' ');
            playerPictureBoxes[playerCardCounter].Image = images[Convert.ToInt32(parts[0]) - 1, Convert.ToInt32(parts[1]) - 1];
            playerCardCounter++;
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

