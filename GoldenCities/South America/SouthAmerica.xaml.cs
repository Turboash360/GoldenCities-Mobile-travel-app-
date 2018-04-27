using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class SouthAmerica : ContentPage
    {
        public SouthAmerica()
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
                    websiteName = "1. Lima, Peru",
                    websiteDescription = "H",
                        
                },

                new ListClass()
                {
                    websiteName = "2. Panama Canal, Panama",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "3. Rio, Brazil",
                    websiteDescription = "H",
                },

               
            };

            SA.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var listclass = (ListClass)menuItem.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }
    }
}
