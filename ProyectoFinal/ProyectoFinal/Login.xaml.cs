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
            InitializeComponent();
            txtNombre.Text = Preferences.Get("Nombre Guardado", "");
            RememberSwitch.IsToggled = Preferences.Get("Guardado Correctamente", false);
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            await Application.Current.MainPage.Navigation.PushModalAsync(new SegundaPage(nombre, correo));

        }

        private void RememberMe_toggle_Switch(object sender, EventArgs e)
        {
            if (RememberSwitch.IsToggled == true)
            {
                Preferences.Set("Nombre Guardado", txtNombre.Text);
                Preferences.Set("Guardado Correctamente", RememberSwitch.IsToggled == true);
                RememberSwitch.ThumbColor = Color.Red;
                RememberSwitch.OnColor = Color.LightCoral;
            }
            else
            {
                Preferences.Remove("Eliminado Correctamente");
                Preferences.Remove("Borrar");
                RememberSwitch.ThumbColor = Color.Gray;
            }


        }

    }
}