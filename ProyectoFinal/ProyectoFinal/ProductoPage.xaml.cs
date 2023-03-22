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
    public partial class ProductoPage : ContentPage
    {
        public ProductoPage()
        {
            InitializeComponent();
            BindingContext = new MyViewModel();
        }
        public async void Btn2_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new ProductoRegistro());
        }
        public class MyViewModel
        {
            public List<string> Images { get; set; }

            public MyViewModel()
            {
                Images = new List<string>
                {
                    /* SET COMPLETO INSPIRADO EN EVANGELION*/
                    "https://tinyurl.com/5dxyabp9",
                    /*SET COMPLETO*/
                    "https://tinyurl.com/2p8taxj2",
                    /*CABINETE*/
                    "https://tinyurl.com/cjj56eap"

                };
            }
        }
    }
}