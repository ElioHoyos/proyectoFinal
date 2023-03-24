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
	public partial class ClienteRegistro : ContentPage
	{
		public ClienteRegistro ()
		{
			InitializeComponent ();
		}
        public async void Button2_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        public async void Button3_Clicked(object sender, EventArgs e)
		{
			await Application.Current.MainPage.Navigation.PopModalAsync();
		}
	}
}