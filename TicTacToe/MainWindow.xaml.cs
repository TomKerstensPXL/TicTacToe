using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        public bool isSinglePlayer = false;
        public string namePlayer1 = "Player 1";
        public string namePlayer2 = "Player 2";
        public bool easyDifficulty = false;
        public bool mediumDifficulty = false;
        public bool hardDifficulty = false;

        private int clicks = 0; // Counter for number of turns
        private const string xPlayer = "X"; 
        private const string yPlayer = "O"; 
        private string currentPlayer;
        private Button[,] board; // 2D array for board buttons
        private int pointXPlayer = 0;
        private int pointYPlayer = 0;
        private Random random;
        private List<Button> emButtons;

        public MainWindow()
        {
            InitializeComponent();
            currentPlayer = xPlayer; 
            currentPlayerLabel.Content = "Press a box to start (X) Starts";
            turnCounterLabel.Content = "Turn: 0";
            playerxLabel.Content = namePlayer1;
            playeryLabel.Content = namePlayer2;

            // Assign UI buttons to the board array
            board = new Button[3, 3] {
                { gameButton1, gameButton2, gameButton3 },
                { gameButton4, gameButton5, gameButton6 },
                { gameButton7, gameButton8, gameButton9 }
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (!string.IsNullOrEmpty(clickedButton.Content?.ToString())) return;

            currentPlayer = (clicks % 2 == 0) ? xPlayer : yPlayer; 
            clickedButton.Background = new SolidColorBrush(Colors.LightGray);
            clickedButton.Content = currentPlayer;

            if (CheckWin(currentPlayer))
            {
                if (MessageBox.Show($"{(currentPlayer == xPlayer ? namePlayer1 : namePlayer2)} wins!\nPlay Again?", "Game Over", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    PlayAgain();
                }
                else
                {
                    MessageBox.Show("Thanks for playing!");
                    Close();
                }
                return;
            }

            clicks++;
            if (clicks == 9)
            {
                MessageBox.Show("It's a tie!", "Tie");
                if (MessageBox.Show("Play Again?", "Restart", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    PlayAgain();
                }
                else
                {
                    MessageBox.Show("Thanks for playing!");
                    Close();
                }
                return;
            }

            currentPlayerLabel.Content = $"Current player: {(currentPlayer == "O" ? namePlayer1 + " (X)" : namePlayer2 + " (O)")}";
            turnCounterLabel.Content = $"Turn: {clicks}";

            if (isSinglePlayer)
            {
                cpuPlayer();
            }
        }

        private bool CheckWin(string player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0].Content?.ToString() == player &&
                    board[i, 1].Content?.ToString() == player &&
                    board[i, 2].Content?.ToString() == player)
                    return true;
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[0, i].Content?.ToString() == player &&
                    board[1, i].Content?.ToString() == player &&
                    board[2, i].Content?.ToString() == player)
                    return true;
            }

            if (board[0, 0].Content?.ToString() == player &&
                board[1, 1].Content?.ToString() == player &&
                board[2, 2].Content?.ToString() == player)
                return true;

            if (board[0, 2].Content?.ToString() == player &&
                board[1, 1].Content?.ToString() == player &&
                board[2, 0].Content?.ToString() == player)
                return true;

            return false;
        }

        private void cpuPlayer()
        {
            random = new Random();
            emButtons = new List<Button>();

            foreach (var button in board)
            {
                if (string.IsNullOrEmpty(button.Content?.ToString()))
                {
                    emButtons.Add(button);
                }
            }

            if (emButtons.Count == 0) return;

            if (easyDifficulty)
            {
                Button aiMove = emButtons[random.Next(emButtons.Count)];
                aiMove.Content = yPlayer;
                aiMove.Background = new SolidColorBrush(Colors.LightGray);
                clicks++;

                if (CheckWin(yPlayer))
                {
                    MessageBox.Show("AI wins!", "Game Over");
                    PlayAgain();
                    return;
                }

                if (clicks == 9)
                {
                    MessageBox.Show("It's a tie!", "Tie");
                    PlayAgain();
                    return;
                }

                currentPlayer = xPlayer;
                currentPlayerLabel.Content = $"Current player: {namePlayer1} (X)";
                return;
            }

            if (mediumDifficulty)
            {
                foreach (var button in emButtons)
                {
                    button.Content = yPlayer;
                    if (CheckWin(yPlayer))
                    {
                        MessageBox.Show("CPU wins!", "Game Over");
                        button.Background = new SolidColorBrush(Colors.LightGray);
                        clicks++;
                        PlayAgain();
                        return;
                    }
                    button.Content = "";
                }

                foreach (var button in emButtons)
                {
                    button.Content = xPlayer;
                    if (CheckWin(xPlayer))
                    {
                        button.Content = yPlayer;
                        button.Background = new SolidColorBrush(Colors.LightGray);
                        clicks++;
                        return;
                    }
                    button.Content = "";
                }

                Button randomMove = emButtons[random.Next(emButtons.Count)];
                randomMove.Content = yPlayer;
                randomMove.Background = new SolidColorBrush(Colors.LightGray);
                clicks++;

                if (clicks == 9)
                {
                    MessageBox.Show("It's a tie!", "Tie");
                    PlayAgain();
                }

                return;
            }
        }

        private void PlayAgain()
        {
            foreach (var button in board)
            {
                button.Content = "";
                button.Background = new SolidColorBrush(Colors.White);
                button.IsEnabled = true;
            }

            if (currentPlayer == xPlayer)
            {
                pointXPlayer += 1;
                playerXScoreTextBox.Text = pointXPlayer.ToString();
            }
            else
            {
                pointYPlayer += 1;
                playerYScoreTextBox.Text = pointYPlayer.ToString();
            }

            currentPlayer = xPlayer;
            clicks = 0;
            currentPlayerLabel.Content = "Current player: " + namePlayer1 + " (X)";
            turnCounterLabel.Content = "Turn: 0";
        }
    }
}
