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
			List<Image> imagenes = new List<Image>()
			{
				new Image() { Title = "Naruto Shippuden", Url = "https://tinyurl.com/3ck8rrmx"},
				new Image() { Title = "Dragon Ball", Url = "https://tinyurl.com/3kxdxmpf"},
				new Image() { Title = "Naruto", Url = "https://tinyurl.com/bdep8b42"}
			};
            
        	}
       
        }

    
}
