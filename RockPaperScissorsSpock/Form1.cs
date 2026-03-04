using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsSpock
{
    public partial class Form1 : Form
    {
        // Score variables
        int wins = 0;
        int losses = 0;
        int ties = 0;

        // Random number generator
        Random ranNumberGenerator = new Random();

        public Form1()
        {
            InitializeComponent();
            UpdateScoreDisplay();
        }

        // 0=Rock, 1=Paper, 2=Scissors, 3=Lizard, 4=Spock
        private void ProcessGame(int playerChoice)
        {
            //Computer chooses between 0 and 4
            int computer = ranNumberGenerator.Next(0, 5);

            if (playerChoice == computer)
            {
                outTextBox.Text = "Tied!";
                ties++;
            }
            else if (CheckIfPlayerWins(playerChoice, computer))
            {
                outTextBox.Text = "Win!";
                wins++;
            }
            else
            {
                outTextBox.Text = "Lose!";
                losses++;
            }

            UpdateScoreDisplay();
        }

      
        private bool CheckIfPlayerWins(int p, int c)
        {
            // 0=Rock, 1=Paper, 2=Scissors, 3=Lizard, 4=Spock
            //Returns true if the player's choice (p) beats the computer's (c)
            return (p == 0 && (c == 2 || c == 3)) || // Rock crushes Scissors and Lizard
                   (p == 1 && (c == 0 || c == 4)) || // Paper covers Rock and disproves Spock
                   (p == 2 && (c == 1 || c == 3)) || // Scissors cuts Paper and decapitates Lizard
                   (p == 3 && (c == 1 || c == 4)) || // Lizard eats Paper and poisons Spock
                   (p == 4 && (c == 0 || c == 2));   // Spock smashes Scissors and vaporizes Rock
        }

        private void btnRock_Click(object sender, EventArgs e) => ProcessGame(0);
        private void btnPaper_Click(object sender, EventArgs e) => ProcessGame(1);
        private void btnScissors_Click(object sender, EventArgs e) => ProcessGame(2);
        private void btnLizard_Click(object sender, EventArgs e) => ProcessGame(3);
        private void btnSpock_Click(object sender, EventArgs e) => ProcessGame(4);

        private void bntReset_Click(object sender, EventArgs e)
        {
            wins = 0;
            losses = 0;
            ties = 0;
            outTextBox.Text = "";
            UpdateScoreDisplay();
        }

        private void UpdateScoreDisplay()
        {
            winsTextBox.Text = wins.ToString();
            lossesTextBox.Text = losses.ToString();
            tiesTextBox.Text = ties.ToString();
        }
    }
}
