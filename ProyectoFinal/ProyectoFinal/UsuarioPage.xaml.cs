﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioPage : ContentPage
    {
        public UsuarioPage()
        {
            InitializeComponent();
        }
        public async void Btn_Clicked(object sender, EventArgs e)
        {

            await Application.Current.MainPage.Navigation.PushModalAsync(new RegistroUsuario());


        }
        

    }
}