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
                    websiteDescription = "Los Angeles is the second largest city in the United States in terms of population and " +
                        "one of the largest in terms of area. It is the center of a five-county metropolitan area and is considered " +
                        "the prototype of the future metropolis—a city on the cutting edge of all of the advantages and the problems " +
                        "of large urban areas.",

                },

                new ListClass()
                {
                    websiteName = "2. New York City, Ny USA",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "3. Honolulu, Hawaii",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "4. Cancun, Mexico",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "5. Acapulco, Mexico",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "6. Mexico City, Mexico",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "7. Ontario, Canada",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "8. Toronto, Canada",
                    websiteDescription = "H",
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
