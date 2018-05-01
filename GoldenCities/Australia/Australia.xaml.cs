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
                    websiteDescription = "The largest city in Australia, and it is one of the most populated city in south america." +
                        "This cosmopolitian city is well known for Opera house and site seeing.",
                },

                new ListClass()
                {
                    websiteName = "2. Alice Springs, Australia",
                    websiteDescription = "The most remote area in central Australia. Well know for the Uluru(Ayres Rock). " +
                        "This Rock can glow in the night time. Isn't that awesome. Many tourists from all over the world" +
                        "come and visit this place to see the red rock glowing in the night time. ",
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
