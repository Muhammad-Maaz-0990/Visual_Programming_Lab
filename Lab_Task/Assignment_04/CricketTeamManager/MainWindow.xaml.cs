using System.Collections.ObjectModel;
using System.Windows;

namespace CricketTeamManager
{
    public partial class MainWindow : Window
    {
        // ObservableCollection to hold the players
        private ObservableCollection<string> players;

        public MainWindow()
        {
            InitializeComponent();
            players = new ObservableCollection<string>();
            PlayersListBox.ItemsSource = players; // Bind ListBox to the ObservableCollection
        }

        private void AddPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            string playerName = PlayerNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Player name cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (players.Contains(playerName))
            {
                MessageBox.Show("Player already exists in the roster.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            players.Add(playerName); // Add new player to the roster
            PlayerNameTextBox.Clear(); // Clear the TextBox
            MessageBox.Show($"{playerName} added to the roster.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void RemovePlayerButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedPlayer = PlayersListBox.SelectedItem as string;
            if (selectedPlayer == null)
            {
                MessageBox.Show("Please select a player to remove.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            players.Remove(selectedPlayer); // Remove selected player from the roster
            MessageBox.Show($"{selectedPlayer} removed from the roster.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
