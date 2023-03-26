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
	public partial class RegistroCategoria : ContentPage
	{
		public RegistroCategoria ()
		{
			InitializeComponent ();
		}

        private void Registrar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Nueva Categoria", "Registrado Correctamente", "ok");
            Navigation.PushModalAsync(new CategoriaPage());
        }

        private void Cancelar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}