using MainScreen.Model;
using System.Windows;
using System.Windows.Media;

namespace WindowsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void getJokeButton_Clicked(object sender, RoutedEventArgs e)
        {
            jokeTextBox.Foreground = Brushes.Fuchsia;
            jokeTextBox.TextAlignment = TextAlignment.Center;
            jokeTextBox.Text = "...geting a joke...";

            var strJoke = await Joke.GetJoke();

            jokeTextBox.Foreground = Brushes.Black;
            jokeTextBox.TextAlignment = TextAlignment.Justify;
            jokeTextBox.Text = strJoke;
        }
    }
}
