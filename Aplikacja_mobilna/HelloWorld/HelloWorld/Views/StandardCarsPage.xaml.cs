using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StandardCarsPage : ContentPage
    {
        public ObservableCollection<Car> Cars { get; set; }
        public StandardCarsPage(List<Car> cars)
        {

            Cars = new ObservableCollection<Car>(cars);
            InitializeComponent();

            CarListView.ItemsSource = Cars;
        }

        public StandardCarsPage()
        {
            Cars = new ObservableCollection<Car>()
            {
                new Car{ Name = "Audi A4", Year = 2010, Color = "Czerwony", Type = CarType.Sedan, Price = 40000},
                new Car{ Name = "Mercedes CLA", Year = 2012, Color = "Biały", Type = CarType.Sedan, Price = 60000}
            };
            InitializeComponent();

            CarListView.ItemsSource = Cars;
        }


        private void CarListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var car = e.SelectedItem as Car;
            Navigation.PushAsync(new CarDetailPage(car));
        }
    }
}