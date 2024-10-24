using System.Numerics;

namespace FirstProjectMauiApp
{
    public partial class MainPage : ContentPage
    {
        private List<string> fruitsCollection;

        public MainPage()
        {
            InitializeComponent();
            fruitsCollection = new List<string>();
            fruitsCollection.Add("Jabłko");
            fruitsCollection.Add("Ananas");
            fruitsCollection.Add("Gruszka");

            fruitPicker.ItemsSource = fruitsCollection;

            fruitPicker.SelectedItem = "Ananas";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string text = messageEntry.Text;
            messageEntry.Text = "";
            messageLabel.Text = "Podano: " + text;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ageLabel.Text = "Wybrano " + ageSlider.Value;
        }

        private void Favorite_Button_Clicked(object sender, EventArgs e)
        {
            favoriteFruitLabel.Text = "Wybrano ulubiony owoc: " + fruitPicker.SelectedItem;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ourImage.Source = "dotnet_bot.png";
        }
    }

}
