using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            TabbedPage tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new FirstPage() { Title = "Pierwsza"});
            tabbedPage.Children.Add(new SecondPage() { Title = "Druga"});
            tabbedPage.Children.Add(new ThirdPage() { Title = "Trzecia"});


            TabbedPage secondTabPage = new TabbedPage() { Title = "Zakł" };
            secondTabPage.Children.Add(new MainPage() { Title = "Główna" });
            secondTabPage.Children.Add(new FirstPage() { Title = "Pierwsza 1" });

            tabbedPage.Children.Add(new NavigationPage(new FirstPage() { Title ="tytul"}) { Title = "Nawigacja" });
            tabbedPage.Children.Add(new NavigationPage(new FirstPage() { Title ="tytul 2"}) { Title = "Nawigacja 2" });

            tabbedPage.Children.Add(secondTabPage);

            MainPage = tabbedPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
