using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarDetailPage : ContentPage
    {
        public Car Car { get; set; }
        public CarDetailPage(Car car)
        {
            Car = car;

            this.BindingContext = Car;
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var result = DisplayAlert("Zamykanie", "Czy chcesz wykonać akcje?", "Tak", "Nie");
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            var result = DisplayActionSheet("Wybierz akcję", "Nie", null, "Akcja 1", "Akcja 2", "Akcja 3");
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            var result = await DisplayPromptAsync("nazwa samochodu", "Podaj nazwę");
        }
    }
}