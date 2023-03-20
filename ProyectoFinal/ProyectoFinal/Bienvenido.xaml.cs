using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bienvenido : ContentPage
	{
		public Bienvenido (string nombre, string correo)
		{
			InitializeComponent ();
            LabelNombre.Text = "Hola " + nombre + " con correo " + correo + " Sea Bienvenid@";
        }

        public async void Button1_Clicked(object sender, EventArgs e)
		{
			await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());

        }

    }
}