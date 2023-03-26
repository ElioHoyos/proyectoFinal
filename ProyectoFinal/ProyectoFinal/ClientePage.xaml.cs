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
    public partial class ClientePage : CarouselPage
    {
        public ClientePage()
        {
            InitializeComponent();
        }
        public async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegistrarCliente ());
        }
    }
}