using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Car> carList = new List<Car>
            {
                new Car{ Name = "Audi A4", Year = 2010},
                new Car{ Name = "Mercedes CLA", Year = 2012},
                new Car{ Name = "Ford Kuga", Year = 2018},
                new Car{ Name = "Ferrari California", Year = 2015},
                new Car{ Name = "Lamborghini Gallardo", Year = 2006},
                new Car{ Name = "BMW X5", Year = 2020},
            };

            CarListView.ItemsSource = carList;
        }
    }
}