namespace NavigateMauiApp.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		AboutPage aboutPage = new AboutPage(messageEntry.Text);
		Navigation.PushAsync(aboutPage);
    }
}