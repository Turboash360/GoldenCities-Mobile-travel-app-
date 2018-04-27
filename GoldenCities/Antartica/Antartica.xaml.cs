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
                    websiteName = "1. South Pole, Antartica",
                    websiteDescription = "One of the hemispheres in Antartica. ",
                },

                new ListClass()
                {
                    websiteName = "2. North Pole, Antartica",
                    websiteDescription = "A random city in Antartica. How do I get there?" +
                        "First, go to south pole. There is a magical portal in south pole which will teleport you to north pole.",
                },

                new ListClass()
                {
                    websiteName = "3. Mc.Murdo Station, Antartica",
                    websiteDescription = "Another random city in Antartica. The only city in Antartica that has life.",
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
