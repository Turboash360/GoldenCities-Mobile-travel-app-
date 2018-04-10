using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;


using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Australia : ContentPage
    {
        public Australia()
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
                    websiteName = "1. Sydney, Australia",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "2. Alice Springs, Australia",
                    websiteDescription = "H",
                },
            };

            AUS.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var listclass = (ListClass)menuItem.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }


    }
}
