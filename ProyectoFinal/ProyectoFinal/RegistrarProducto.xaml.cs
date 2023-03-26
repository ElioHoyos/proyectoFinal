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
    public partial class RegistrarProducto : ContentPage
    {
        public RegistrarProducto()
        {
            InitializeComponent();
        }
        private void Registrar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Nueva Producto", "Registrado Correctamente", "ok");
            Navigation.PushModalAsync(new ProductoPage ());
        }

        private void Cancelar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}