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
        int playerBet, playerValue = 0;     //Bet = Players Bet, Value = Players Hand
        int compValue = 0;
        int playerBalance = 100;
        int cardValue;

        private void hitBtn_Click(object sender, EventArgs e)
        {
            Random card = new Random();
            cardValue = card.Next(1, 10);

            playerValue = playerValue + cardValue;
            playerHandLbl.Text = Convert.ToString(playerValue);
            gameCheck();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (playerBet == 0 || playerBet > playerBalance)
            {
                MessageBox.Show("You do not have enough money in your balance to bet.");
            } else {
                hitBtn.Enabled = true;
                standBtn.Enabled = true;
                resetBtn.Enabled = false;

                valueOneBtn.Enabled = false;
                valueFiveBtn.Enabled = false;
                valueTenBtn.Enabled = false;
                valueTwentyBtn.Enabled = false;
                valueFiftyBtn.Enabled = false;
                valueHundredBtn.Enabled = false;

                playerValue = 0;
                playerHandLbl.Text = Convert.ToString(playerValue);

                startBtn.Enabled = false;
                playerBalance = playerBalance - playerBet;
                balanceValueLbl.Text = Convert.ToString(playerBalance);
            }
        }

        private void standBtn_Click(object sender, EventArgs e)
        {
            gameInactive();

            do
            {
                Random card = new Random();
                cardValue = card.Next(1, 10);

                compValue = compValue + cardValue;
                compHandLbl.Text = Convert.ToString(compValue);
                gameCheck();
            } while (compValue < playerValue && compValue < 21);
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
            resetBtn.Enabled = true;

            valueOneBtn.Enabled = true;
            valueFiveBtn.Enabled = true;
            valueTenBtn.Enabled = true;
            valueTwentyBtn.Enabled = true;
            valueFiftyBtn.Enabled = true;
            valueHundredBtn.Enabled = true;
            startBtn.Enabled = true;
        }

        private void valueOneBtn_Click(object sender, EventArgs e)
        {
            playerBet = playerBet + 1;
            betValueLbl.Text = Convert.ToString(playerBet);
        }

        private void valueFiveBtn_Click(object sender, EventArgs e)
        {
            playerBet = playerBet + 5;
            betValueLbl.Text = Convert.ToString(playerBet);
        }

        private void valueTenBtn_Click(object sender, EventArgs e)
        {
            playerBet = playerBet + 10;
            betValueLbl.Text = Convert.ToString(playerBet);
        }

        private void valueTwentyBtn_Click(object sender, EventArgs e)
        {
            playerBet = playerBet + 20;
            betValueLbl.Text = Convert.ToString(playerBet);
        }

        private void valueFiftyBtn_Click(object sender, EventArgs e)
        {
            playerBet = playerBet + 50;
            betValueLbl.Text = Convert.ToString(playerBet);
        }

        private void valueHundredBtn_Click(object sender, EventArgs e)
        {
            playerBet = playerBet + 100;
            betValueLbl.Text = Convert.ToString(playerBet);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            playerBet = 0;
            betValueLbl.Text = Convert.ToString(playerBet);
        }

        public void gameCheck() //Runs a check to see if player has won.
        {
            if (playerValue == 21)
            {
                MessageBox.Show("You have won! You win $" + playerBet * 2);
                playerBalance = playerBalance + playerBet * 2;
                balanceValueLbl.Text = Convert.ToString(playerBalance);

                gameInactive();
            }
            else if (playerValue > 21)
            {
                MessageBox.Show("You have lost. Try Again!");
                gameInactive();
            }
            else if (compValue >= 16 && compValue < 21 && compValue > playerValue) //Bigger16, smaller21, biggerplayer
            {
                MessageBox.Show("You have been beat!");
                gameInactive();
            }
            else if (compValue > 21)
            {
                MessageBox.Show("You have won! Computer busted.");
                gameInactive();
            }
            else if (compValue == 21)
            {
                MessageBox.Show("Computer hit 21, you lost!");
                gameInactive();
            }
            else if (compValue == playerValue)
            {
                MessageBox.Show("Draw! You get your money back.");
                gameInactive();
            }
        }
    }
}
