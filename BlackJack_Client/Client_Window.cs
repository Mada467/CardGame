using System;
using System.Windows.Forms;

namespace BlackJack_Client
{
    public partial class Client_Window : Form
    {
        private Game game; // Instanța jocului

        public Client_Window()
        {
            InitializeComponent(); // Inițializează componentele formularului
            game = new Game();     // Creăm jocul
        }

        // Eveniment pentru butonul "Start Game"
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            game.StartGame(); // Pornește jocul
        }
    }
}

