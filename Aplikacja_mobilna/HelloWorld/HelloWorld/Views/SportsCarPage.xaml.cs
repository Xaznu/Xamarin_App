﻿using HelloWorld.Models;
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
    public partial class SportsCarPage : ContentPage
    {
        public ObservableCollection<Car> Cars { get; set; }
        public SportsCarPage(List<Car> cars)
        {

            Cars = new ObservableCollection<Car>(cars);


            InitializeComponent();

            CarListView.ItemsSource = Cars;
        }

        public SportsCarPage()
        {
            Cars = new ObservableCollection<Car>()
            {
                new Car{ Name = "Ferrari California", Year = 2015, Color = "Czerwony", Type = CarType.Sport, Price = 600000},
                new Car{ Name = "Lamborghini Gallardo", Year = 2006, Color = "Niebieski", Type = CarType.Sport, Price = 700000},
                new Car{ Name = "Maserati granturismo s coupe", Year = 2019, Color = "Czarny", Type = CarType.Sport, Price = 350000}
            };

            InitializeComponent();
            CarListView.ItemsSource = Cars;
        }


        private void CarListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var car = e.SelectedItem as Car;
            //Navigation.PushAsync(new CarDetailPage(car));
            Navigation.PushModalAsync(new CarDetailPage(car), false);
        }
    }
}