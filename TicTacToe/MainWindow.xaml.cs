using System.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isSinglePlayer = false;
        public string namePlayer1 = "player 1"; // Store the name of player 1
        public string namePlayer2 = "player 2"; // Store the name of player 2
        public bool easyDifficulty = false;
        public bool mediumDifficulty = false;
        public bool hardDifficulty = false;


        private int clicks = 0; // Counter for the number of clicks (turns)
        private const string xPlayer = "X"; // Represents Player 1's symbol
        private const string yPlayer = "O"; // Represents Player 2's symbol
        private string currentPlayer;
        private string onClick; // To store the current symbol (X or O) when a button is clicked
        private Button[,] board; // 2D array to represent the Tic-Tac-Toe board
        private int pointXPlzyer;
        private int pointYPlzyer;
        private OpeningPage opening = new();
        

        public MainWindow()
        {
            InitializeComponent(); // Initializes the components (UI elements)
            currentPlayer = xPlayer; // X always starts first
            currentPlayerLabel.Content = "Press a box to start (X) Starts"; // Set the initial label for player 1
            turnCounterLabel.Content = $"Turn:  {clicks.ToString()}"; // Set the initial turn counter
            playerxLabel.Content = namePlayer1;
            playeryLabel.Content = namePlayer2;

            // Initialize the 2D array that represents the board with the actual buttons from the UI
            board = new Button[3, 3] {
                { gameButton1, gameButton2, gameButton3 }, // First row of buttons
                { gameButton4, gameButton5, gameButton6 }, // Second row of buttons
                { gameButton7, gameButton8, gameButton9 }  // Third row of buttons
            };
        }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                Button clickedButton = (Button)sender; // Cast the sender to a Button so we can manipulate it

                if (!string.IsNullOrEmpty(clickedButton.Content?.ToString())) return; // If the button has already been clicked, exit

                currentPlayer = (clicks % 2 == 0) ? xPlayer : yPlayer; // Determine current player based on clicks (even: X, odd: O)

                clickedButton.Background = new SolidColorBrush(Colors.LightGray); // Change the background color to LightGray

                clickedButton.Content = currentPlayer; // Set the content of the button to the current player's symbol


                if (CheckWin(currentPlayer)) // Check if the current player has won
                {
                    if (MessageBox.Show($"{(currentPlayer == xPlayer ? namePlayer1 : namePlayer2)} wins!\nPlay Again?", "Game over", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        PlayAgain(); // restarts the game and adding a point to the winner
                    }
                    else
                    {
                        MessageBox.Show("Thanks for playing!");
                        this.Close(); // Closes the programmen after the pop up box
                        opening.Close();
                    }
                }
                clicks++; // Increment the click counter
                if (clicks == 9) // If all cells are filled, it's a tie
                {
                    MessageBox.Show("It's a tie!", "Tie");
                    if (MessageBox.Show("Play Again?", "Restart", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        PlayAgain();
                    }
                    else
                    {

                        MessageBox.Show("Thanks for playing!");
                        this.Close(); // Closes the programmen after the pop up box
                        opening.Close();
                    }
                    return;
                }

                currentPlayerLabel.Content = $"Current player: {(currentPlayer == "O" ? namePlayer1 + " (X)" : namePlayer2 + " (O)")}"; // Update the label for the next player
            
                turnCounterLabel.Content = $"Turn: {clicks}"; // Update the turn counter
                if (isSinglePlayer)
                {
                    cpuPlayer();
                }
            }

        private bool CheckWin(string player)
        {
            // Check if the player has won by checking rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0].Content?.ToString() == player && // Check the first button in the row
                    board[i, 1].Content?.ToString() == player && // Check the second button in the row
                    board[i, 2].Content?.ToString() == player)   // Check the third button in the row
                    return true;
            }

            // Check if the player has won by checking columns
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i].Content?.ToString() == player && // Check the first button in the column
                    board[1, i].Content?.ToString() == player && // Check the second button in the column
                    board[2, i].Content?.ToString() == player)   // Check the third button in the column
                    return true;
            }

            // Check if the player has won by checking the left-to-right diagonal
            if (board[0, 0].Content?.ToString() == player &&
                board[1, 1].Content?.ToString() == player &&
                board[2, 2].Content?.ToString() == player)
                return true;

            // Check if the player has won by checking the right-to-left diagonal
            if (board[0, 2].Content?.ToString() == player &&
                board[1, 1].Content?.ToString() == player &&
                board[2, 0].Content?.ToString() == player)
                return true;

            return false; // If no winning combination is found, return false
        }
        private void cpuPlayer()
        {
            if (easyDifficulty == true)
            {
                Random rand = new Random();
                List<Button> emptyButtons = new List<Button>();

                // Find empty spots
                foreach (var button in board)
                {
                    if (string.IsNullOrEmpty(button.Content?.ToString()))
                    {
                        emptyButtons.Add(button);
                    }
                }

                if (emptyButtons.Count > 0)
                {
                    Button aiMove = emptyButtons[rand.Next(emptyButtons.Count)]; // Pick a random empty button
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

                    currentPlayer = xPlayer;  // Switch back to human player
                    currentPlayerLabel.Content = $"Current player: {namePlayer1} (X)";
                }
            }
            else if (mediumDifficulty == true)
            {
                foreach (var button in board)
                {
                    if (string.IsNullOrEmpty(button.Content?.ToString()))
                    {
                        button.Content = yPlayer;
                        if (CheckWin(yPlayer))
                        {
                            MessageBox.Show("CPU wins!", "Game Over");
                            PlayAgain();
                            return;
                        }
                        button.Content = ""; // Undo move
                    }
                }

                // Try to block player's winning move
                foreach (var button in board)
                {
                    if (string.IsNullOrEmpty(button.Content?.ToString()))
                    {
                        button.Content = xPlayer;
                        if (CheckWin(xPlayer))
                        {
                            button.Content = yPlayer;
                            break;
                        }
                        button.Content = ""; // Undo move
                    }
                }

                // Otherwise, make a random move
                Random rand = new Random();
                List<Button> emptyButtons = board.Cast<Button>().Where(b => string.IsNullOrEmpty(b.Content?.ToString())).ToList();

                if (emptyButtons.Count > 0)
                {
                    Button aiMove = emptyButtons[rand.Next(emptyButtons.Count)];
                    aiMove.Content = yPlayer;
                    aiMove.Background = new SolidColorBrush(Colors.LightGray);
                }

            } 
        }


        private void PlayAgain()
        {
            foreach (var button in board)
            {
                button.Content = "";// Reset button content to empty
                button.Background = new SolidColorBrush(Colors.White);// Reset background to white
                button.IsEnabled = true;
                
            }
            if (currentPlayer == xPlayer)
            {
                pointXPlzyer += 1;
                playerXScoreTextBox.Text = pointXPlzyer.ToString();
            }
            else
            {
                pointYPlzyer += 1;
                playerYScoreTextBox.Text = pointYPlzyer.ToString();
            }
            currentPlayer = xPlayer;
            clicks = 0; // Reset the click counter (starts a new game)
            currentPlayerLabel.Content = "Current player: " + namePlayer1 + " (X)";
            turnCounterLabel.Content = "Turn: 0";
        }
    }
}
