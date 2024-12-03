using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form1 : Form
    {
        private Game game; // Instanța jocului

        public Form1()
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

