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
    public partial class CategoriaPage : ContentPage
    {
        public CategoriaPage()
        {
            InitializeComponent();
            
        }
        public class Superhero
        {
            public string Name { get; set; }

            public string AlterEgo { get; set; }

            public string Photo { get; set; }

            public List<string> TeamAffiliations { get; set; }
        }
    }
}