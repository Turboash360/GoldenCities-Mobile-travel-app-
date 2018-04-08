using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Africa : ContentPage
    {
        public Africa()
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
                    websiteName = "Cairo, Egypt",
                },

                new ListClass()
                {
                    websiteName = "Seychelles",
                },

                new ListClass()
                {
                    websiteName = "Durban, South Africa",
                },
            };

            AFR.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var button = (Button)sender;
            var listclass = (ListClass)button.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }

    }
}
