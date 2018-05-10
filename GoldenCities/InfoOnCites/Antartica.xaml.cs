using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.InfoOnCites;
using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Antartica : ContentPage
    {
        ListClass[] MyList = new ListClass[10];
        public Antartica()
        {
            InitializeComponent();
            PopulateViewList();
        }

        private void PopulateViewList()
        {
            string[] SP_places = {"South Pole City"};
            string[] NP_places = { "Santa Town", "North Pole City"};
            string[] MM_places = {"McMuradoBase"};

            double[] SP_lat = { -90 };
            double[] NP_lat = { 83.40, 90 };
            double[] MM_lat = { -77.50599 };

            double[] SP_long = { 0 };
            double[] NP_long = { -29.50, 0 };
            double[] MM_long = { 166.395999 };


            var List = new ObservableCollection<ListClass>();

            var item = new ListClass
            {
                IconSource = "Antartica.png",
                websiteName = "1. South Pole, Antartica",
                websiteDescription = "One of the hemispheres in Antartica. ",
                latitude = SP_lat,
                longitude = SP_long,
                places = SP_places,
                wetherkey = "&q=Nuuk"
            };
            List.Add(item);
            MyList[0] = item;

            var item1 = new ListClass
            {
                IconSource = "Antartica.png",
                websiteName = "2. North Pole, Antarctica",
                websiteDescription = "A random city in Antartica. How do I get there?" +                         "First, go to south pole. There is a magical portal in south pole which will teleport you to north pole.", 
                latitude = NP_lat,
                longitude = NP_long,
                places = NP_places,
                wetherkey = "&q=Nuuk"

            };
            List.Add(item1);
            MyList[1] = item1;

            var item2 = new ListClass
            {
                IconSource = "Antartica.png",
                websiteName = "3. Mc.Murdo Station, Antartica",
                websiteDescription = "Another random city in Antartica. The only city in Antartica that has life.",
                latitude = MM_lat,
                longitude = MM_long,
                places = MM_places,
                wetherkey = "&q=Nuuk"
            };
            List.Add(item2);
            MyList[2] = item2;

            ANT.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var listclass = (ListClass)menuItem.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;

            int index = button.Text[0] - '0';
            index--;

            Navigation.PushAsync(new CitiesMoreInfo(MyList[index]));
        }
    }
}