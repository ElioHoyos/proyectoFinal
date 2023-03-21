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
		public async void Btn_Clicked(object sender, EventArgs e)
		{
            bool answer = await DisplayAlert("Question?", "¿Estas Seguro de Salir?", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
        }
	}
}