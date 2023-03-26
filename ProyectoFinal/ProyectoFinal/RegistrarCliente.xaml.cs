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
    public partial class RegistrarCliente : ContentPage
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }
        private void Registrar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Nueva Cliente", "Registrado Correctamente", "ok");
            Navigation.PushModalAsync(new ClientePage());
        }

        private void Cancelar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}