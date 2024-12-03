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

        GameController gameController;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            List<Card> cards = new List<Card>();

            gameController = new GameController();

            cards = gameController.StartGame();

            for (int i = 0; i < cards.Count; i++)
            {
                playerCardsTextBox.AppendText(cards[i].ToString());
            }  
        }

        
    }
}
