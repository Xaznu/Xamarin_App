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

        private void CarListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var car = e.SelectedItem as Car;
            Navigation.PushAsync(new CarDetailPage(car));
        }
    }
}