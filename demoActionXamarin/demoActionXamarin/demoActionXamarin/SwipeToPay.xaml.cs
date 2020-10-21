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
    public partial class SwipeToPay : ContentPage
    {
        public SwipeToPay()
        {
            InitializeComponent();
        }

        private async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}