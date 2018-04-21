using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class DelhiPage : ContentPage
    {
        public DelhiPage()
        {
            InitializeComponent();
        }

        void Handle_ClickedMaps(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DelhiMaps());
        }
    }
}
