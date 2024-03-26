using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterNavigationPage : NavigationPage
    {
		public MasterNavigationPage ()
		{
			InitializeComponent ();
		}
	}
}