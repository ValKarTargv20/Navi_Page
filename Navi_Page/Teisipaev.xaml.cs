using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navi_Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teisipaev : ContentPage
    {
        public Teisipaev()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Esmaspaev());
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kolmapaev());
        }
    }
}