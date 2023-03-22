using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlyoutMenuPage : ContentPage
	{
		public FlyoutMenuPage ()
		{
			InitializeComponent ();
		}
		public async void Button_Clicked(object sender, EventArgs e)
		{
            bool answer = await DisplayAlert("Question?", "¿Estas Seguro de Salir?", "Yes", "No");
            if(answer)
			{
              await  Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
            }
			else{
				await Application.Current.MainPage.Navigation.PopModalAsync();

            }
        }
	}
}