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
        public Login()
        {
            InitializeComponent();
        }
        public  void Btn_Clicked(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string password = txtPassword.Text;
            if ((correo == "Arcangel") && (password == "753096"))
            {
                 Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
                DisplayAlert("Info", "Bienvenido Usuario", "OK");
                

            }
            else
            {
                DisplayAlert("Alerta", "Usuario o Contraseña Incorrecta","OK");
            }
            
            
            

        }
        public async void Btn2_Clicked(object sender, EventArgs e)
        {
            
            await Application.Current.MainPage.Navigation.PushModalAsync(new Registro());
        }
    }
}