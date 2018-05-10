using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.InfoOnCites;
using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Europe : ContentPage
    {
        ListClass[] MyList = new ListClass[10];
        public Europe()
        {
            InitializeComponent();
            PopulateViewList();
        }
        private void PopulateViewList()
        {
            string[] LO_places = {"Big Ben", "South Bank","London Transport Museum", "Imperial War Museum","London Square"};
            string[] PA_places = {"St. Vincient de Paul", "75 St. Rue, Bob's Hotel", "Effel Tower", "Saint-Germain-des-Prés Abbey", "Mona Lisa Muesuem"};
            string[] RE_places = {"Tommi's Burger Joint", "GeoIceLand Tours", "Golden Circle"};
            string[] RO_places = {"Vatican Museum","Colosseum", "Palatine Hill", "Sistine Chapel", "Leaning Tower of Piza"};
            string[] MA_places = {"Madrid Marriott Museum", "Prado National Museum", "Mercado San Miguel", "Calle Avila", "Royal Palace of Madrid"};
            string[] BE_places = { "Berlin Wall", "Reichstag Building", "Pergamon Museum", "East Side Gallery", "Brandenburg Gate"};

            double[] LO_lat = { 51.5037, 51.4991, 51.5146, 51.4994, 51.5143};
            double[] PA_lat = { 48.8790, 48.8335, 48.8584, 48.853867, 48.860294 };
            double[] RE_lat = { 64.1260, 64.1360, 64.1360};
            double[] RO_lat = { 41.9067, 41.8904, 41.8905, 41.9032, 43.7232};
            double[] MA_lat = { 40.4577, 40.4140, 40.4157, 40.6601, 40.4182};
            double[] BE_lat = { 52.5504, 52.5188, 52.5213, 52.5054, 52.5165};


            double[] LO_long = { -0.1246, -0.1079, -0.1172, -0.0999, -0.1303};
            double[] PA_long = { 2.3519, 2.3191, 2.2945, 2.334723, 2.338629  };
            double[] RE_long = { -21.8162, -21.8236, -21.8236};
            double[] RO_long = { 12.4536, 12.4922, 12.4874, 12.4544, 10.3966};
            double[] MA_long = { -3.5432, -3.6917, -3.7085, -4.6886, -3.7142};
            double[] BE_long = { 13.3931, 13.3763, 13.3969, 13.4396, 13.3779};

            var List = new ObservableCollection<ListClass>();

            var item = new ListClass
            {

                IconSource = "London.png",
                websiteName = "1. London, UK",
                websiteDescription = "Known for Big Ben, London Bridge and the South Bank.",
                latitude = LO_lat,
                longitude = LO_long,
                places = LO_places,
                wetherkey = "&q=London"
            };
            List.Add(item);
            MyList[0] = item;

            var item1 = new ListClass
            {
                IconSource = "paris.png",
                websiteName = "2. Paris, France",
                websiteDescription = "Known for the Effel Tower. The best place of romance and french fries.",
                latitude = PA_lat,
                longitude = PA_long,
                places = PA_places,
                wetherkey = "&q=Paris"
            };
            List.Add(item1);
            MyList[1] = item1;

            var item2 = new ListClass
            {
                IconSource = "reykjavik.png",
                websiteName = "3. Iceland",
                websiteDescription = "Not very well known, but it does have gorgeous scenery. A best place to get fish salmon. " +
                    "They call it Iceland, but there are no ice. It is green",
                latitude = RE_lat,
                longitude = RE_long,
                places = RE_places,
                wetherkey = "&q=Reykjavik"

            };
            List.Add(item2);
            MyList[2] = item2;

            var item3 = new ListClass
            {
                IconSource = "Rome.png",
                websiteName = "4. Rome, Italy",
                websiteDescription = "Known for the Leaning Tower of Pisa. It has been leaning like always. " +
                    "It has been leaning since Iccas Newton and Gallieo proved the theorm of Gravity.",

                latitude = RO_lat,
                longitude = RO_long,
                places = RO_places,
                wetherkey = "&q=Rome"
            };
            List.Add(item3);
            MyList[3] = item3;


            var item4 = new ListClass
            {
                IconSource = "madrid.png",
                websiteName = "5. Madrid, Spain",
                websiteDescription = "Known for the Royal Palace of Madrid. ",
                latitude = MA_lat,
                longitude = MA_long,
                places = MA_places,
                wetherkey = "&q=Madrid"
            };
            List.Add(item4);
            MyList[4] = item4;

            var item5 = new ListClass
            {
                IconSource = "berlin.png",
                websiteName = "6. Berlin, Germany",
                websiteDescription = "Known for the Berlin Wall. A nice historical site. " +
                    "This city was divided since the end of World War 2 till 1989. ",
                latitude = BE_lat,
                longitude = BE_long,
                places = BE_places,
                wetherkey = "&q=Berlin"
            };
            List.Add(item5);
            MyList[5] = item5;

            EUR.ItemsSource = List;
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