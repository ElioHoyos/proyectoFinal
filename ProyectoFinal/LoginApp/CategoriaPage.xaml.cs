using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriaPage : CarouselPage
    {
        public CategoriaPage()
        {
            InitializeComponent();
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CategoriaRegistro());
        }
    }
}