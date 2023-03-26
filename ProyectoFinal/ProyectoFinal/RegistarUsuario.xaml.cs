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
    public partial class RegistarUsuario : ContentPage
    {
        public RegistarUsuario()
        {
            InitializeComponent();
        }
        private void Registrar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Nueva Usuario", "Registrado Correctamente", "ok");
            Navigation.PushModalAsync(new UsuarioPage ());
        }

        private void Cancelar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}