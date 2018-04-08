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
                    websiteName = "1. London, UK"
                },

                new ListClass()
                {
                    websiteName = "2. Paris, France"
                },

                new ListClass()
                {
                    websiteName = "3. Iceland"
                },

                new ListClass()
                {
                    websiteName = "4. Rome, Italy"
                },

                new ListClass()
                {
                    websiteName = "5. Madrid, Spain"
                },

                new ListClass()
                {
                    websiteName = "6. Berlin, Germany"
                },


            };

            EUR.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var button = (Button)sender;
            var listclass = (ListClass)button.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }

    }
}
