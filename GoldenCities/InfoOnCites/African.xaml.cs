using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;
using GoldenCities.InfoOnCites;
using Xamarin.Forms;

namespace GoldenCities
{
    public partial class African : ContentPage
    {
        ListClass[] MyList = new ListClass[7];

        public African()
        {
            InitializeComponent();
            PopulateViewList();
        }

        private void PopulateViewList()
        {
            string[] CO_places = { "Pyramids of Giza", "Al Azhar Park", "Saqqara", "Egyptian Muesuem", "Sphinx"};
            string[] SE_places = {"Mahe","Victoria", "Beau Vallon", "La Digue"};
            string[] DU_places = {"Shaka Marine World", "Umgeni River Bird Park", "Botanic Gardens", "Suncoast Casino and Entertainment World", "Moses Mabhida Stadium"};
            string[] AD_places = {"Holy Trinity Cathedral","Adadi Mariyam", "Mt.Entoto", "Afar Region", "Lake Tana"};

            double[] CO_lat = {29.9792, 30.0406, 29.5216, 30.0478, 29.9753};
            double[] SE_lat = { -4.6827, -4.6191, -4.6211, -4.3591};
            double[] DU_lat = { -29.8086, -29.8086, -29.8479, -29.8354, -29.8290};
            double[] AD_lat = { 9.0303, 8.6305, 9.1156, 11.7559, 12.0266};

            double[] CO_long = { 31.1342, 31.2647, 31.125897, 31.2336, 31.1376};
            double[] SE_long = { 55.4804, 55.4513, 55.4278, 55.8412};
            double[] DU_long = { 31.0459, 31.0174, 31.0082, 31.0346, 31.0304};
            double[] AD_long = { 38.7664, 38.5020, 38.7722, 40.9587, 37.3035};




            var List = new ObservableCollection<ListClass>();

            var item = new ListClass
            {
                websiteName = "Cairo, Egypt",
                websiteDescription = "It's the capital of Egypt.It's the largest city in Egypt, and" + "also the 15th largest city in the world.",
                latitude = CO_lat,
                longitude = CO_long,
                places = CO_places,
                wetherkey = "&q=Cairo"
            };
            List.Add(item);
            MyList[0] = item;

            var item1 = new ListClass
            {
                websiteName = "Seychelles",
                websiteDescription = "It's a republic in France, and one of the sovereign states" + "in the Indian Ocean.",
                latitude = SE_lat,
                longitude = SE_long,
                places = SE_places,
                wetherkey = "&q=Seychelles"
            };
            List.Add(item1);
            MyList[1] = item1;

            var item2 = new ListClass
            {
                websiteName = "Durban, South Africa",
                websiteDescription = "Located on east coast of South Africa, and one of the largest cities.",
                latitude = DU_lat,
                longitude = DU_long,
                places = DU_places,
                wetherkey = "&q=Durban"

            };
            List.Add(item2);
            MyList[2] = item2;

            var item3 = new ListClass
            {
                websiteName = "Adidas Ababa, Ethopia",
                websiteDescription = "It's the capital of Ethiopia.",

                latitude = AD_lat,
                longitude = AD_long,
                places = AD_places,
                wetherkey = "&q=Addis Ababa"
            };
            List.Add(item3);
            MyList[3] = item3;

            AFR.ItemsSource = List;
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