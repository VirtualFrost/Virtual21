using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualTwentyOne
{
    public partial class formMain : Form
    {
        int playerBet, playerBalance, playerValue = 0;     //Bet = Players Bet, Balance = Balance, Value = Players Hand
        int compValue = 0;

        int cardValue;

        private void hitBtn_Click(object sender, EventArgs e)
        {
            Random card = new Random();
            cardValue = card.Next(1, 10);

            playerValue = playerValue + cardValue;
            playerHandLbl.Text = Convert.ToString(playerValue);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            hitBtn.Enabled = true;
            standBtn.Enabled = true;

            valueOneBtn.Enabled = false;
            valueFiveBtn.Enabled = false;

            playerValue = 0;
            playerHandLbl.Text = Convert.ToString(playerValue);

            if (playerBet == 0)
            {
                //You must bet more than $0.
            }

            gameCheck();
        }

        private void standBtn_Click(object sender, EventArgs e)
        {
            gameInactive();
        }

        public formMain()
        {
            InitializeComponent();

            playerBalance = 100;
            balanceValueLbl.Text = Convert.ToString(playerBalance);
            gameInactive();
        }

        public void gameInactive()
        {
            hitBtn.Enabled = false;
            standBtn.Enabled = false;
        }

        public void gameCheck() //Runs a check to see if player has won.
        {
            if (playerValue == 21)
            {
                //User won
            }
            else if (playerValue > 21)
            {
                //User Lost
            } else if (playerValue < 21 && compValue <= 21)
            {

            }
        }
    }
}
