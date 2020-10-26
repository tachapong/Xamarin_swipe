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
    public partial class ClickSwipeTopay : ContentPage
    {
        public ClickSwipeTopay()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}