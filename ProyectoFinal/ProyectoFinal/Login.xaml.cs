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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

		public void Botton_Clicked(object sender, EventArgs e)
		{
            String sUsuario = txtUsuario.Text;
            String sContraseña = txtContraseña.Text;

            if ((sUsuario == "Danny_ge@gmail.com") && (sContraseña == "dany24edu22"))
            {
                DisplayAlert("Hola", "Bienvenido al Sistema", "ok");
                Navigation.PushModalAsync(new MainPage ());
            }
            else
            {
                DisplayAlert("Error", "El Usuario o Contraseña es Incorrecto", "Ok");
            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Registrar ());
        }

    }
}
