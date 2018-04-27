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
                    websiteDescription = "Welcome to New York. This is the most populated city in the United States. " +
                        "Really a great tourist spot. Super Great City with Statues Of Liberty." +
                        ""
                },

                new ListClass()
                {
                    websiteName = "3. Honolulu, Hawaii USA",
                    websiteDescription = "Ohau Blends the cosmopolitan luxury and breathtaking scenery" +
                        "more than any othe Hawaiian Islands. The state capital Honolulu showcases the " +
                        "Urban appeal. Nearby You" +
                        ""
                },

                new ListClass()
                {
                    websiteName = "4. Cancun, Mexico",
                    websiteDescription = " It is a valuable tourist destination in Mexico. One of the" +
                        "most well known cities in Mexico. It has a tropical climate.",
                },

                new ListClass()
                {
                    websiteName = "5. Acapulco, Mexico",
                    websiteDescription = "It is another well known city in Mexico. It has a tropical wet and " +
                        "dry climate. It's the largest city in Mexico by far.",
                },

                new ListClass()
                {
                    websiteName = "6. Mexico City, Mexico",
                    websiteDescription = "It's the capital of Mexico.",
                },

                new ListClass()
                {
                    websiteName = "7. Ontario, Canada",
                    websiteDescription = "One of the most well known cities in Canada.",
                },

                new ListClass()
                {
                    websiteName = "8. Toronto, Canada",
                    websiteDescription = "Another one of the most well known cities in Canada.",
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
