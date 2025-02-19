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
         public OpeningPage()
        {
            InitializeComponent();
        }

        private void readyButton_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow game = new MainWindow();
            game.namePlayer1 = nameXPlayerBox.Text;
            game.namePlayer2 = nameYPlayerBox.Text;
            game.Show();
            this.Close();
            Application.Current.MainWindow = game;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            nameYPlayerBox.Visibility = Visibility.Hidden;
            nameYPlayerLabel.Visibility = Visibility.Hidden;
            easyRadio.Visibility = Visibility.Visible;
            hardRadio.Visibility = Visibility.Visible;
            mediumRadio.Visibility = Visibility.Visible;
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            nameYPlayerBox.Visibility = Visibility.Visible;
            nameYPlayerLabel.Visibility = Visibility.Visible;
            easyRadio.Visibility = Visibility.Hidden;
            hardRadio.Visibility = Visibility.Hidden;
            mediumRadio.Visibility = Visibility.Hidden;
        }
    }
}
