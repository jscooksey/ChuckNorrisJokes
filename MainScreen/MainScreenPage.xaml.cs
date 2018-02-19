using MainScreen.Model;
using Xamarin.Forms;

namespace MainScreen
{
    public partial class MainScreenPage : ContentPage
    {
        public MainScreenPage()
        {
            InitializeComponent();
        }

        async void getJoke_Clicked(object sender, System.EventArgs e)
        {
            jokeLabel.TextColor = Color.Fuchsia;
            jokeLabel.Text = "...geting a joke...";
            var strJoke = await Joke.GetJoke();
            jokeLabel.TextColor = Color.Black;
            jokeLabel.Text = strJoke;

        }
    }
}
