using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
		}
        public void Button16_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage ());
        }
		public void Button17_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new LoginUI());
		}
    }
}