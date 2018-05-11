using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;
using GoldenCities.InfoOnCites;
using Xamarin.Forms;


namespace GoldenCities
{
    public partial class NorthAmerica : ContentPage
    {
        ListClass[] MyList = new ListClass[10];

        public NorthAmerica()
        {
            InitializeComponent();
            PopulateViewList();
        }

        private void PopulateViewList()
        {
            string[] LA_places = { "Universal Studios Hollywood", "Griffith Park and Griffith Observatory", "Disneyland Resort" };
            string[] NY_places = { "Statue of Liberty", "Central Park", "Rockefeller Center and Top of the Rock Observation Deck" };
            string[] HO_places = { "Makani Catamaran Sail", "Honolulu Museum of Art", "Waikiki Beach" };
            string[] CA_places = { "Chichen Itza", "Isla Mujeres", "El Rey Ruins" };
            string[] AC_places = { "Playa Condesa", "Paititi del Mar", "San Diego Fort" };
            string[] MC_places = { "Zócalo: The Birthplace of the Constitution", "The National Museum of Anthropology", "Templo Mayor and the Great Pyramid of Tenochtitlán" };
            string[] ON_places = { "Niagara Falls", "Toronto's CN Tower", "Royal Ontario Museum" };
           
           
            double[] LA_lat = { 34.138117, 34.118434, 33.810485 };
            double[] NY_lat = { 40.689249, 40.782865, 40.759243 };
            double[] HO_lat = { 21.294374, 21.303898, 21.276218 };
            double[] CA_lat = { 20.684285, 21.232180, 21.061141 };
            double[] AC_lat = { 16.855025, 16.787317, 16.849939 };
            double[] MC_lat = { 19.432602, 19.426003, 19.434604 };
            double[] ON_lat = { 43.082816, 43.642566, 43.667710 };

            double[] LA_long = { -118.353378, -118.300393, -117.918989 };
            double[] NY_long = { -74.044500, -73.965355, -73.979294 };
            double[] HO_long = { -157.857259, -157.848708, -157.827091 };
            double[] CA_long = { -88.567783, -86.734093, -86.781224 };
            double[] AC_long = { -99.873986, -99.793213, -99.902372 };
            double[] MC_long = { -99.133205, -99.186279, -99.131881 };
            double[] ON_long = { -79.074163, -79.387057, -79.394777 };



            var List = new ObservableCollection<ListClass>();

            var item = new ListClass
            {
                IconSource = "LA.png",
                websiteName = "1. Los Angeles, CA USA",
                websiteDescription = "Los Angeles is the second largest city in the United States in terms of population and " +
                        "one of the largest in terms of area. It is the center of a five-county metropolitan area and is considered " +
                        "the prototype of the future metropolis—a city on the cutting edge of all of the advantages and the problems " +
                        "of large urban areas.",
                latitude = LA_lat,
                longitude = LA_long,
                places = LA_places,
                wetherkey = "&q=LA"
            };
            List.Add(item);
            MyList[0] = item;

            var item1 = new ListClass
            {
                IconSource = "NewYorkCities.png",
                websiteName = "2. New York City, Ny USA",
                websiteDescription = "Welcome to New York. This is the most populated city in the United States. " +
                        "Really a great tourist spot. Super Great City with Statues Of Liberty",
                latitude = NY_lat,
                longitude = NY_long,
                places = NY_places,
                wetherkey = "&q=NY"
            };
            List.Add(item1);
            MyList[1] = item1;

            var item2 = new ListClass
            {
                IconSource = "Honolulu.png",
                websiteName = "3. Honolulu, Hawaii USA",
                websiteDescription = "Ohau Blends the cosmopolitan luxury and breathtaking scenery" +
                        "more than any othe Hawaiian Islands. The state capital Honolulu showcases the " +
                        "Urban appeal. Nearby You",
                latitude = HO_lat,
                longitude = HO_long,
                places = HO_places,
                wetherkey = "&q=Honolulu"

            };
            List.Add(item2);
            MyList[2] = item2;

            var item3 = new ListClass
            {
                IconSource = "Cancun.png",
                websiteName = "4. Cancun, Mexico",
                websiteDescription = " It is a valuable tourist destination in Mexico. One of the" +
                        "most well known cities in Mexico. It has a tropical climate.",
                latitude = CA_lat,
                longitude = CA_long,
                places = CA_places,
                wetherkey = "&q=Cancun"
            };
            List.Add(item3);
            MyList[3] = item3;

            var item4 = new ListClass
            {
                IconSource = "acapulco-beach.png",
                websiteName = "5. Acapulco, Mexico",
                websiteDescription = "It is another well known city in Mexico. It has a tropical wet and " +
                        "dry climate. It's the largest city in Mexico by far.",
                latitude = AC_lat,
                longitude = AC_long,
                places = AC_places,
                wetherkey = "&q=Acapulco"

            };
            List.Add(item4);
            MyList[4] = item4;

            var item5 = new ListClass
            {
                IconSource = "MC.png",
                websiteName = "6. Mexico City, Mexico",
                websiteDescription = "It's the capital of Mexico. Ther city itself is pretty old. " +
                    "In the early days, the Aztec Indians settled on the lake. They built a city called Tenochtitlán.",
                latitude = MC_lat,
                longitude = MC_long,
                places = MC_places,
                wetherkey = "&q=Mexico City"
            };
            List.Add(item5);
            MyList[5] = item5;

            var item6 = new ListClass
            {
                IconSource = "Ontario.png",
                websiteName = "7. Ontario, Canada",
                websiteDescription = "One of the most well known cities in Canada. They speak French in Canada, as" +
                    "well as English.",
                latitude = ON_lat,
                longitude = ON_long,
                places = ON_places,
                wetherkey = "&q=Ontario Canada"
            };
            List.Add(item6);
            MyList[6] = item6;

            NA.ItemsSource = List;
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