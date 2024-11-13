namespace NavigateMauiApp.Pages;

public partial class AboutPage : ContentPage
{
	public AboutPage(string message)
	{
		InitializeComponent();
        messageLabel.Text = message;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}