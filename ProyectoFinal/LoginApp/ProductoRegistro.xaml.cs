﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductoRegistro : ContentPage
    {
        public ProductoRegistro()
        {
            InitializeComponent();
        }

        public async void Button8_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        public async void Button9_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}