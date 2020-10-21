using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demoActionXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            myButton1.Clicked += (sender, arg) =>
            {
                Navigation.PushAsync(new Slider());
            };
            myButton2.Clicked += (sender, arg) =>
            {
                Navigation.PushAsync(new MainPage());
            };
            myButton3.Clicked += (sender, arg) =>
            {
                Navigation.PushAsync(new SwipeToPay());
            };
            myButton4.Clicked += (sender, arg) =>
            {
                Navigation.PushAsync(new SwipeAndClick());
            };
        }
    }
}