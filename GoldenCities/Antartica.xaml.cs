using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Antartica : ContentPage
    {
        public Antartica()
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
                    websiteName = "1. South Pole City, Antartica",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "2. Happy Feat, Antartica",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "3. Snowy Land, Antartica",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "4, Dead Penguin",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "5. Floating Ice Berg",
                    websiteDescription = "H",
                },
               
            };

            ANT.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var listclass = (ListClass)menuItem.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }

    }
}
