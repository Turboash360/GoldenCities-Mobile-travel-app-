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
                    websiteDescription = "One of the hemispheres in Antartica.",
                },

                new ListClass()
                {
                    websiteName = "2. Happy Feet, Antartica",
                    websiteDescription = "A random city in Antartica",
                },

                new ListClass()
                {
                    websiteName = "3. Snowy Land, Antartica",
                    websiteDescription = "Another random city in Antartica",
                },

                new ListClass()
                {
                    websiteName = "4,  Penguin",
                    websiteDescription = "Another random city in Antartica",
                },

                new ListClass()
                {
                    websiteName = "5. Mc.Murdo Station",
                    websiteDescription = "A research station. No one actually lives there, except" +
                        "for people who actually work as scientists there and conducts research.",
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
