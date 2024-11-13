using NavigateMauiApp.Pages;

namespace NavigateMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Home home = new Home();
            home.Title = "Strona domowa";

            NavigationPage navigationPage = new NavigationPage(home);

            MainPage = navigationPage;
        }
    }
}
