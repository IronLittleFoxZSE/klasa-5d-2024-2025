using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace EssentialsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlashLightPage : ContentPage
    {
        public FlashLightPage()
        {
            InitializeComponent();
        }

        private void TurnOn_Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Flashlight.TurnOnAsync();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void TurnOf_Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Flashlight.TurnOffAsync();
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}