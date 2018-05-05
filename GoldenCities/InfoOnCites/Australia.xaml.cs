using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;
using GoldenCities.InfoOnCites;
using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Australia : ContentPage
    {
        ListClass[] MyList = new ListClass[7];

        public Australia()
        {
            InitializeComponent();
            PopulateViewList();
        }

        private void PopulateViewList()
        {
            string[] Syd_places = { "Port Jackson Bay", "Bondi Beach", " Strand Arcade", "Queen Victoria Building (QVB)", "Broadway Sydney" };
            string[] Alice_places = { "The Larapinta Trail", "The Kangaroo Sanctuary", "Yubu Napa Art Gallery", " Desert Rose Inn" };

            double[] Syd_lat = { -33.8455, -33.8914, -33.8691, -33.8704, -33.8841 };
            double[] Alice_lat = { -26.2470, -23.6989, -23.7014, -23.6960 };

            double[] Syd_long = { 151.2488, 151.2800, 151.2080, 151.2080, 151.1967 };
            double[] Alice_long = { 135.9736, 133.8837, 133.8812, 133.8796 };
            var List = new ObservableCollection<ListClass>();

            var item = new ListClass
            {
                IconSource = "sydney.png",
                websiteName = "Sydney, Australia",
                websiteDescription = "Biggest city in Australia.",
                latitude = Syd_lat,
                longitude = Syd_long,
                places = Syd_places,
                wetherkey = "&q=Sydney"
            };
            List.Add(item);
            MyList[0] = item;

            var item1 = new ListClass
            {
                IconSource = "Alice-Springs.png",
                websiteName = " Alice Springs, Australia",
                websiteDescription = " Alice Springs is often called the Alice for short" +
                    "Uluru is the most iconic natural landform in Australia — " +
                    "and its formation is an equally special story of creation, " +
                    "destruction and reinvention. The origins of Uluru(and Kata Tjuta) date back about " +
                    "500 million years, to around the same time the Australian continent was formed. " +
                    "Large crustal blocks were merging together to create the island of Australia — " +
                    "a process similar to the way India is ramming into the Eurasian continent today. " +
                    "As a result, Himalayan - sized mountain ranges were being built.",


                latitude = Alice_lat,
                longitude = Alice_long,
                places = Alice_places,
                wetherkey = "&q=Alice"
            };
            List.Add(item1);
            MyList[1] = item1;
            AUS.ItemsSource = List;
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

