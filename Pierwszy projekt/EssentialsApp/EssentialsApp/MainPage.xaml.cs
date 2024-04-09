using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EssentialsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FlashLight_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlashLightPage());
        }
    }
}
