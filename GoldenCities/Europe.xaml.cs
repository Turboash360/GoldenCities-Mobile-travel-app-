using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Europe : ContentPage
    {
        public Europe()
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
                    websiteName = "1. London, UK",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "2. Paris, France",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "3. Iceland",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "4. Rome, Italy",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "5. Madrid, Spain",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "6. Berlin, Germany",
                    websiteDescription = "H",
                        
                },


            };

            EUR.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var listclass = (ListClass)menuItem.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }

    }
}
