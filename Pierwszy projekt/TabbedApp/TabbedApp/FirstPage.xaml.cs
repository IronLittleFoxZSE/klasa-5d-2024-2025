using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Navigation != null)
            {
                TabbedPage tabbedPage = new TabbedPage() { Title = "Druga strona" };
                tabbedPage.Children.Add(new FirstPage() { Title = "Pierwsza" });
                tabbedPage.Children.Add(new SecondPage() { Title = "Druga" });
                tabbedPage.Children.Add(new ThirdPage() { Title = "Trzecia" });
                Navigation.PushAsync(tabbedPage);
            }
        }
    }
}