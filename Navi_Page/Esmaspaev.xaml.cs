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
    public partial class Esmaspaev : ContentPage
    {
        public Esmaspaev()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teisipaev());
        }
    }
}