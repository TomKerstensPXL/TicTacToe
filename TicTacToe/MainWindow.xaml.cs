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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int clicks = 0; // Counter for the number of clicks (turns)
        private string namePlayer1; // Store the name of player 1
        private string namePlayer2; // Store the name of player 2
        private const string xPlayer = "X"; // Represents Player 1's symbol
        private const string yPlayer = "O"; // Represents Player 2's symbol
        private string onClick; // To store the current symbol (X or O) when a button is clicked
        private Button[,] board; // 2D array to represent the Tic-Tac-Toe board
        private int pointXPlzyer;
        private int pointYPlzyer;

        public MainWindow()
        {
            InitializeComponent(); // Initializes the components (UI elements)

            currentPlayerLabel.Content = "Current player: " + namePlayer1 + " (X)"; // Set the initial label for player 1
            turnCounterLabel.Content = $"Turn:  {clicks.ToString()}"; // Set the initial turn counter

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

            string currentPlayer = (clicks % 2 == 0) ? xPlayer : yPlayer; // Determine current player based on clicks (even: X, odd: O)

            clickedButton.Background = new SolidColorBrush(Colors.LightGray); // Change the background color to LightGray

            clickedButton.Content = currentPlayer; // Set the content of the button to the current player's symbol

            if (CheckWin(currentPlayer)) // Check if the current player has won
            {
                if (MessageBox.Show($"Player {(currentPlayer == "X" ? namePlayer1 : namePlayer2)} wins!\nPlay Again?", "Game over", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    PlayAgain(); // restarts the game and adding a point to the winner
                }
                else
                {
                    MessageBox.Show("Thanks for playing!");
                    Close(); // Closes the programmen after the pop up box
                }
            }
            else if (clicks == 9)
            {
                MessageBox.Show("It's a tie!!", "Tie");
                if (MessageBox.Show($"Player {(currentPlayer == "X" ? namePlayer1 : namePlayer2)} wins!\nPlay Again?", "Game over", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    PlayAgain(); // restarts the game and adding a point to the winner
                }
                else
                {
                    MessageBox.Show("Thanks for playing!", "Thanks");
                    Close(); // Closes the programmen after the pop up box
                }
            }

            currentPlayerLabel.Content = $"Current player: {(currentPlayer == "X" ? namePlayer1 + " (X)" : namePlayer2 + " (O)")}"; // Update the label for the next player
            turnCounterLabel.Content = $"Turn: {clicks + 1}"; // Update the turn counter
            clicks++; // Increment the click counter
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

        private void PlayAgain()
        {
            foreach (var button in board)
            {
                button.Content = "";// Reset button content to empty
                button.Background = new SolidColorBrush(Colors.White);// Reset background to white
            }
            if (currentPlayerLabel.Content.Equals("X"))
            {
                pointXPlzyer += 1;
            }
            else
            {
                pointYPlzyer += 1;
            }
            clicks = 0; // Reset the click counter (starts a new game)
        }
    }
}
