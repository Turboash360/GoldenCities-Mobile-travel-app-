using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;
using GoldenCities.InfoOnCites;
using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Asia : ContentPage
    {
        ListClass[] MyList = new ListClass[7];

        public Asia()
        {
            InitializeComponent();
            PopulateViewList();
        }

        private void PopulateViewList()
        {
            string[] Delhi_places = {"Taj Mahal", "Agra Fort", "India Gate", "Red Fort", "Lotus Temple" };
            string[] Male_places = { "Male", "Baa Atoll", "Meeru Island" };
            string[] Dubai_places = {"Dubai", "Atlantis Hotel", "Aquaventure WaterPark", "Dubai Underwater Aquarium", "Lost Chambers Aquarium" };
            string[] Kuala_Lumpur_places = { "Batu Caves", "Petronas Tower", "Genting Highlands" };
            string[] Singapore_places = { "Sentosa, Merlion", "Singapore Flyer", "Garden by the Bay", "Singapore Botanic Garden" };
            string[] Tokyo_places = { "Skytree", "Tokyo Tower", "Mt Fuji", "Shinjuku Gyo - en" };
            string[] Moscow_places = { "Lenin Mausoleum", "Red Square", "Alexander Garden" };

            double[] Delhi_lat = { 27.1750, 27.1795, 28.6125, 28.6562, 28.5535 };
            double[] Male_lat = { 4.1755, 5.2396, 4.4533 };
            double[] Dubai_lat = { 25.1750, 25.1304, 25.1336, 25.1974, 25.1319 };
            double[] Kuala_Lumpur_lat = { 3.2379, 3.1578, 3.4237 };
            double[] Singapore_lat = { 1.2494, 1.2868, 1.2893, 1.2816, 1.3138 };
            double[] Tokyo_lat = { 35.7101, 35.6586, 35.3606, 35.6852 };
            double[] Moscow_lat = { 55.7537, 55.7539, 55.7521 };



            double[] Delhi_long = { 78.0422, 78.0211, 77.2295, 77.2410, 78.2588 };
            double[] Male_long = { 73.5093, 72.9933, 73.7169 };
            double[] Dubai_long = { 55.2708, 55.1171, 55.1204, 55.2791, 55.1184 };
            double[] Kuala_Lumpur_long = { 101.6840, 101.745, 101.7938 };
            double[] Singapore_long = { 103.8303, 103.8545, 103.8631, 103.8636, 103.8159 };
            double[] Tokyo_long = { 139.8107, 139.7454, 138.7278, 139.7101 };
            double[] Moscow_long = { 37.6199, 37.6208, 37.6137 };


            var List = new ObservableCollection<ListClass>();



            var item1 = new ListClass
            {
                IconSource = "Taj_Mahal.png",
                websiteName = "1. Delhi/Agra, India",
                websiteDescription = "India's capital and major gateway of the country, " +                         "contemporary Delhi is bustling metropolis, which successfully " +                         "combines in its fold the ancient and the modern. Its strategic " +                         "location was one of the prime reasons why successive dynasties " +                         "chose it as their seat of power. It is one of the most populates" +                         "city in the world and also in India. There are some wonderful tourist attractions" +                         "such as Taj Mahal. ", 
                latitude = Delhi_lat,
                longitude = Delhi_long,
                places = Delhi_places,
                wetherkey = "&q=Delhi"
            };
            List.Add(item1);
            MyList[0] = item1;

            var item2 = new ListClass
            {
                IconSource = "Maldives.png",
                websiteName = "2. Male, Maldives",
                websiteDescription = "The isolated city in the island of Maldives, off coast of the Indian" +                         "Ocean where there is enjoyable time in doin watersports activities.",



                latitude = Male_lat,
                longitude = Male_long,
                places = Male_places,
                wetherkey = "&q=Maldives"

            };
            List.Add(item2);
            MyList[1] = item2;

            var item3 = new ListClass
            {
                IconSource = "Dubai.png",                     websiteName = "3. Dubai, UAE",                     websiteDescription = "One of the most luxurious cities in the Arabian Peninsula." +                         "Most of the tourist from all over the world come to this city to visit this artificial" +                         "futuristic city.",


                latitude = Dubai_lat,
                longitude = Dubai_long,
                places = Dubai_places,
                wetherkey = "&q=Dubai"
            };
            List.Add(item3);
            MyList[2] = item3;

            var item4 = new ListClass
            {
                IconSource = "Singapore.png",
                websiteName = "4. Singapore, Singapore",
                websiteDescription = "One of the luxurious cities in South East Asia. Tourist come here to" +                         "visit the merilion, and the sentosa islands. ", 
                latitude = Singapore_lat,
                longitude = Singapore_long,
                places = Singapore_places,
                wetherkey = "&q=Singapore"

            };
            List.Add(item4);
            MyList[3] = item4;

            var item5 = new ListClass
            {

                IconSource = "Kuala_Lumpur.png",
                websiteName = "5. Kuala Lumpur, Malaysia",
                websiteDescription = "Another city in south east asia.  ", 
                latitude = Kuala_Lumpur_lat,
                longitude = Kuala_Lumpur_long,
                places = Kuala_Lumpur_places,
                wetherkey = "&q=Kuala Lumpur"
            };
            List.Add(item5);
            MyList[4] = item5;

            var item6 = new ListClass
            {
                IconSource = "Tokyo.png",
                websiteName = "6. Tokyo, Japan",
                websiteDescription = "The most well known city in Japan and also the capital city.",


                latitude = Tokyo_lat,
                longitude = Tokyo_long,
                places = Tokyo_places,
                wetherkey = "&q=Tokyo"
            };
            List.Add(item6);
            MyList[5] = item6;




            var item = new ListClass
            {
                IconSource = "Moscow.png",
                websiteName = "7. Moscow, Russia",
                websiteDescription = "The most well known city in Russia and also the capital city.",  
                latitude = Moscow_lat,
                longitude = Moscow_long,
                places = Moscow_places,
                wetherkey = "&q=Moscow"
            };
            List.Add(item);
            MyList[6] = item;



            AS.ItemsSource = List;
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