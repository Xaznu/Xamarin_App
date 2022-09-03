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
    public partial class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();
            CreateLayout();
        }

        private void CreateLayout()
        {
            var content = new StackLayout
            {
                Margin = new Thickness(30)
            };

            var titleLabel = new Label
            {
                Text = "Hello World",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                Margin = new Thickness(0, 30, 0, 100),
                HorizontalOptions = LayoutOptions.Center
            };
            content.Children.Add(titleLabel);

            var loginLabel = new Label
            {
                Text = "Login",
                FontSize = 12,
                FontAttributes = FontAttributes.Bold
            };
            content.Children.Add(loginLabel);

            var loginEntry = new Entry
            {
                Placeholder = "Login",
                Keyboard = Keyboard.Text,
                HorizontalTextAlignment = TextAlignment.Center
            };
            content.Children.Add(loginEntry);

            var passwordLabel = new Label
            {
                Text = "Hasło",
                FontSize = 12,
                FontAttributes = FontAttributes.Bold
            };
            content.Children.Add(passwordLabel);

            var passwordEntry = new Entry
            {
                Placeholder = "Hasło",
                Keyboard = Keyboard.Text,
                IsPassword = true,
                HorizontalTextAlignment = TextAlignment.Center
            };
            content.Children.Add(passwordEntry);

            var buttonStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Spacing = 20
            };

            var loginButton = new Button
            {
                Text = "Zaloguj",
                WidthRequest = 150,
                BackgroundColor = Color.LightBlue,
                CornerRadius = 10
            };
            loginButton.Clicked += Button_Clicked;
            buttonStackLayout.Children.Add(loginButton);

            var registerButton = new Button
            {
                Text = "Utwórz konto",
                WidthRequest = 150,
                BackgroundColor = Color.LightBlue,
                CornerRadius = 10
            };
            registerButton.Clicked += Button_Clicked_1;
            buttonStackLayout.Children.Add(registerButton);

            content.Children.Add(buttonStackLayout);

            this.Content = content;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}