using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.Generic;


namespace ProyectoFinal
{
    public partial class ProductoPage : ContentPage
    {
        private const string productUrl = "https://fakestoreapi.com/products";
        private readonly HttpClient httpClient = new HttpClient();

        public ObservableCollection<Product> Monkeys { get; set; } = new ObservableCollection<Product>();
        public ProductoPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
       

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var productJson = await httpClient.GetStringAsync(productUrl);
            var monkeys = JsonConvert.DeserializeObject<Product[]>(productJson);


            foreach (var monkey in monkeys)
            {
                Monkeys.Add(monkey);
            }
            Carousel.ItemsSource = Monkeys;
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                Carousel.Position = (Carousel.Position + 1) % Monkeys.Count;
                return true;
            }));


        }

        public async void Btn2_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new ProductoRegistro());
        }
    }
}