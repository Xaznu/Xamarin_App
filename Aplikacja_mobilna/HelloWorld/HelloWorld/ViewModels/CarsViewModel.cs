using HelloWorld.Models;
using HelloWorld.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{
    class CarsViewModel
    {
        public ObservableCollection<CarGroup> CarList { get; private set; }
        public bool IsRefreshing { get; set; }
        private INavigation _navigation;

        public CarsViewModel(INavigation navigation)
        {
            _navigation = navigation;
            CarList = new ObservableCollection<CarGroup>
            {
                new CarGroup("Samochody sportowe", new List<Car>
                {
                    new Car{ Name = "Ferrari California", Year = 2015, Color = "Czerwony", Type = CarType.Sport, Price = 600000},
                    new Car{ Name = "Lamborghini Gallardo", Year = 2006, Color = "Niebieski", Type = CarType.Sport, Price = 700000},
                    new Car{ Name = "Maserati granturismo s coupe", Year = 2019, Color = "Czarny", Type = CarType.Sport, Price = 350000}
                }),
                new CarGroup("Samochody osobowe", new List<Car>
                {
                    new Car{ Name = "Audi A4", Year = 2010, Color = "Czerwony", Type = CarType.Sedan, Price = 40000},
                    new Car{ Name = "Mercedes CLA", Year = 2012, Color = "Biały", Type = CarType.Sedan, Price = 60000}
                }),
                new CarGroup("SUV", new List<Car>
                {
                    new Car{ Name = "Ford Kuga", Year = 2018, Color = "Czerwony", Type = CarType.SUV, Price = 80000},
                    new Car{ Name = "BMW X5", Year = 2020, Color = "Carny", Type = CarType.SUV, Price = 120000},
                })
            };
        }

        public void NavigateToCarDeatilPage(Car car)
        {
            _navigation.PushAsync(new CarDetailPage(car));
        }

        public void DisplayAlert(string message, string title)
        {
            App.Current.MainPage.DisplayAlert(title, message, "Ok");
        }

        public void RemoveCarFromCollection(Car car)
        {
            foreach (var carGroup in CarList)
            {
                if (carGroup.Contains(car))
                {
                    carGroup.Remove(car);
                }
            }
        }

        public void RefresLissView()
        {
            var carList = new List<Car>
            {
                new Car()
                {
                    Name = "Jeep Grand Cherokee",
                    Year = 2010
                },
                new Car()
                {
                    Name = "Toyota Land Cruiser",
                    Year = 2009
                }
            };

            var carGroup = new CarGroup("Samochody terenowe", carList);
            CarList.Add(carGroup);
        }
    }
}
