using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Asia : ContentPage
    {
        public Asia()
        {
            InitializeComponent();
            PopulateViewList();
        }

        public void PopulateViewList()
        {
            var List = new ObservableCollection<ListClass>()
            {
                new ListClass()
                {
                    websiteName = "1. Delhi/Agra, India",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "2. Male, Maldives",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "3. Dubai, United Arab Emirates",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "4. Singapore, Singapore",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "5. Kuala Lumpur, Malaysia",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "6. Tokyo, Japan",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "7. Moscow, Russia",
                    websiteDescription = "H",


                },
            };

            AS.ItemsSource = List;

        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var listclass = (ListClass)menuItem.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }

    }
}
