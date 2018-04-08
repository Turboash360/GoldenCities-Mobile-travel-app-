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
                },

                new ListClass()
                {
                    websiteName = "2. Male, Maldives",
                },

                new ListClass()
                {
                    websiteName = "3. Dubai, United Arab Emirates",
                },

                new ListClass()
                {
                    websiteName = "4. Singapore, Singapore",
                },

                new ListClass()
                {
                    websiteName = "5. Kuala Lumpur, Malaysia",
                },

                new ListClass()
                {
                    websiteName = "6. Tokyo, Japan",
                },

                new ListClass()
                {
                    websiteName = "7. Moscow, Russia",
                },
            };

            AS.ItemsSource = List;

        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var button = (Button)sender;
            var listclass = (ListClass)button.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }

    }
}
