using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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
            txtNombre.Text = Preferences.Get("Nombre Guardado", "");
            RememberSwitch.IsToggled = Preferences.Get("Guarado Correctamente", false);
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string correo = txtCor.Text;
            await Application.Current.MainPage.Navigation.PushModalAsync(new Bienvenido(nombre, correo));

        }

        private void RememberMe_toggle_Switch(object sender, ToggledEventArgs e)
        {
            if (RememberSwitch.IsToggled == true)
            {
                Preferences.Set("Nombre Guardado", txtNombre.Text);
                Preferences.Set("Guardado Correctamente", RememberSwitch.IsToggled == true);
                RememberSwitch.ThumbColor = Color.Red;
                RememberSwitch.OnColor = Color.Green;
            }
            else
            {
                Preferences.Remove("Elimando Correctamente");
                Preferences.Remove("Borrado");
                RememberSwitch.ThumbColor = Color.Gray;
            }
        }
    }
}