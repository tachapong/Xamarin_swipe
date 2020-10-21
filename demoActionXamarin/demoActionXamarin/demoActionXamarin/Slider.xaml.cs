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
    public partial class Slider : ContentPage
    {
        public Slider()
        {
            InitializeComponent();

            frame.TranslationY = 300;
            frame.IsVisible = false;
            myButton.IsVisible = true;

            myButton.Clicked += (sender, arg) =>
            {
                frame.IsVisible = true;
                frame.TranslateTo(0, 0, 300);
                myButton.IsVisible = false;
            };
        }

        //private async void SwipeItem_Invoked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Page2());
        //}

        async void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            if (value == 100)
            {
                await Navigation.PushAsync(new Page2());
            }
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            frame.IsVisible = false;
            frame.TranslationY = 300;
            myButton.IsVisible = true;
        }
    }
}