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
    public partial class CarouselNavigationPage : CarouselPage
    {
        public CarouselNavigationPage()
        {
            InitializeComponent();

            var sportsCarPage = new SportsCarPage();
            var sedanCarPage = new StandardCarsPage();
            var SuvPage = new SuvPage();

            Children.Add(sportsCarPage);
            Children.Add(sedanCarPage);
            Children.Add(SuvPage);
        }
    }
}