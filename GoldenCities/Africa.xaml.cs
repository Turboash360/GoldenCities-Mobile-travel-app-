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
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "Seychelles",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "Durban, South Africa",
                    websiteDescription = "H",
                },
            };

            AFR.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var listclass = (ListClass)menuItem.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }

    }
}
