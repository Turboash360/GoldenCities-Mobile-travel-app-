using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class NorthAmerica : ContentPage
    {
        public NorthAmerica()
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
                    websiteName = "1. Los Angeles, CA USA",
                },

                new ListClass()
                {
                    websiteName = "2. New York City, Ny USA",
                },

                new ListClass()
                {
                    websiteName = "3. Honolulu, Hawaii",
                },

                new ListClass()
                {
                    websiteName = "4. Cancun, Mexico",
                },

                new ListClass()
                {
                    websiteName = "5. Acapulco, Mexico",
                },

                new ListClass()
                {
                    websiteName = "6. Mexico City, Mexico",
                },

                new ListClass()
                {
                    websiteName = "7. Ontario, Canada",
                },

                new ListClass()
                {
                    websiteName = "8. Toronto, Canada",
                },

            };

            NA.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var listclass = (ListClass)menuItem.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }
    }
}
