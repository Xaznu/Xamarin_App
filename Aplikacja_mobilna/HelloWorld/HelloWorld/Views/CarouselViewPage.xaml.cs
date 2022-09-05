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
    public partial class CarouselViewPage : ContentPage
    {
        public ObservableCollection<Car> Cars { get; set; }
        public CarouselViewPage()
        {
            InitializeComponent();

            Cars = new ObservableCollection<Car>
            {
                new Car{ Name = "Ferrari California", Year = 2015, Color = "Czerwony", Type = CarType.Sport, Price = 600000},
                new Car{ Name = "Lamborghini Gallardo", Year = 2006, Color = "Niebieski", Type = CarType.Sport, Price = 700000},
                new Car{ Name = "Maserati granturismo s coupe", Year = 2019, Color = "Czarny", Type = CarType.Sport, Price = 350000},
                new Car{ Name = "Audi A4", Year = 2010, Color = "Czerwony", Type = CarType.Sedan, Price = 40000},
                new Car{ Name = "Mercedes CLA", Year = 2012, Color = "Biały", Type = CarType.Sedan, Price = 60000},
                new Car{ Name = "Ford Kuga", Year = 2018, Color = "Czerwony", Type = CarType.SUV, Price = 80000},
                new Car{ Name = "BMW X5", Year = 2020, Color = "Carny", Type = CarType.SUV, Price = 120000},
            };

            carouselViewControl.ItemsSource = Cars;
        }
    }
}