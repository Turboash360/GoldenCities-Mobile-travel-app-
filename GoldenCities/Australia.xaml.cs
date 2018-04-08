using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;


using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Australia : ContentPage
    {
        public Australia()
        {
            InitializeComponent();
            PopulateViewList();
        }

        private void PopulateViewList()
        {
            var List = new ObservableCollection<ListClass>()
            {
                new ListClass()
                {
                    websiteName = "1. Sydney, Australia"
                },

                new ListClass()
                {
                    websiteName = "2. Alice Springs, Australia"
                },
            };

            AUS.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var button = (Button)sender;
            var listclass = (ListClass)button.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }


    }
}
