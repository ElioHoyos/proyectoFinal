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

            if ((sUsuario == "DannySk") && (sContraseña == "dany24edu22"))
            {
                Navigation.PushModalAsync(new MainPage ());
            }
            else
            {
                lblresultado.Text = "La contraseña o Usuario son incorrectos";
            }
        }
        public async void Boton2_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Registrar());
        }

	}
}