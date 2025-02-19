using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for OpeningPage.xaml
    /// </summary>
    public partial class OpeningPage : Window
    {
        private MainWindow game;
        private bool isSingleplayer = false;
        public OpeningPage()
        {
            InitializeComponent();
        }

        private void readyButton_Click(object sender, RoutedEventArgs e)
        {
            game = new MainWindow()
            {
                namePlayer1 = nameXPlayerBox.Text,
                namePlayer2 = isSingleplayer ? "CPU" : nameYPlayerBox.Text,
                isSinglePlayer = isSingleplayer,
                easyDifficulty = easyRadio.IsChecked == true,
                mediumDifficulty = mediumRadio.IsChecked == true,
                hardDifficulty = hardRadio.IsChecked == true
            };

            game.Show();
            this.Close();
            Application.Current.MainWindow = game;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
            isSingleplayer = true;

            nameYPlayerBox.Visibility = Visibility.Hidden;
            nameYPlayerLabel.Visibility = Visibility.Hidden;
            easyRadio.Visibility = Visibility.Visible;
            hardRadio.Visibility = Visibility.Visible;
            mediumRadio.Visibility = Visibility.Visible;
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            
            isSingleplayer = false;

            nameYPlayerBox.Visibility = Visibility.Visible;
            nameYPlayerLabel.Visibility = Visibility.Visible;
            easyRadio.Visibility = Visibility.Hidden;
            hardRadio.Visibility = Visibility.Hidden;
            mediumRadio.Visibility = Visibility.Hidden;
            easyRadio.IsChecked = false;
            hardRadio.IsChecked = false;
            mediumRadio.IsChecked = false;
        }

        
    }
}
