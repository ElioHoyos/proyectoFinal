using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
	public partial class Carrusel : ContentPage
	{
		public Carrusel ()
		{
			InitializeComponent ();
            BindingContext = new MyViewModel();
        }
        public class MyViewModel
        {
            public List<string> Images { get; set; }

            public MyViewModel()
            {
                Images = new List<string>
        {
            "https://tinyurl.com/58vmxuh5",
            "https://tinyurl.com/mpc9kpfx"


        };
            }
        }

    }
}