using System;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ComputerChoice(out string computerMove)
        {
            int randomNumber = random.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    computerMove = "Rock";
                    break;
                case 2:
                    computerMove = "Paper";
                    break;
                case 3:
                    computerMove = "Scissors";
                    break;
                default:
                    throw new InvalidOperationException("Invalid random number generated");
            }
        }

        private void DetermineWinner(string userMove, string computerMove)
        {
            if (userMove == computerMove)
            {
                MessageBox.Show("It's a tie! Play again.");
            }
            else if ((userMove == "Rock" && computerMove == "Scissors") ||
                     (userMove == "Scissors" && computerMove == "Paper") ||
                     (userMove == "Paper" && computerMove == "Rock"))
            {
                MessageBox.Show($"You win! {userMove} beats {computerMove}.");
            }
            else
            {
                MessageBox.Show($"You lose! {computerMove} beats {userMove}.");
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayGame("Rock");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayGame("Paper");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayGame("Scissors");
        }

        private void PlayGame(string userMove)
        {
            string computerMove;
            ComputerChoice(out computerMove);

            MessageBox.Show($"Computer chose {computerMove}.");

            DetermineWinner(userMove, computerMove);
        }
    }
}