using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.InfoOnCites;
using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class SouthAmerica : ContentPage
    {
        ListClass[] MyList = new ListClass[10];
        public SouthAmerica()
        {
            InitializeComponent();
            PopulateViewList();
        }

        private void PopulateViewList()
        {
            string[] Machu = { "Machu Picchu" };
            string[] Panama = { "Panama Canal" };
            string[] Rio = { "Rio de Janeiro" };
            string[] Quito = { "Quito" };
            string[] Bogota = { "Bogotá" };
            string[] Santiago = { "Santiago" };



            double[] Machu_lat = { -13.163068 };
            double[] Panama_lat = { 9.38743 };
            double[] Rio_lat = { -22.970722 };
            double[] Quito_lat = { -0.180653 };
            double[] Bogota_lat = { 4.624335 };
            double[] Santiago_lat = { -33.459229 };


            double[] Machu_long = { -72.545128 };
            double[] Panama_long = { -79.91863 };
            double[] Rio_long = { -43.182365 };
            double[] Quito_long = { -78.467834 };
            double[] Bogota_long = { -74.063644 };
            double[] Santiago_long = { -70.645348 };


            var List = new ObservableCollection<ListClass>();

            var item = new ListClass
            {
                IconSource = "Machu.png",
                websiteName = "1. Machu Picchu, Peru",
                websiteDescription = "As Peru’s most popular tourist attraction and one of the world’s most famous archaeological wonders, " +
                                     "Machu Picchu is located 7,000 feet (2,100 meters) above sea level in the Andes Mountains. " +
                                     "Although this magnificent Inca site provokes more mysteries than facts, " +
                                     "it is believed that Machu Picchu was first built around the middle of the 15th century as a military " +
                                     "fortress then later used as an estate for Inca royalty. Visitors can explore Machu Picchu " +
                                     "and see well-preserved buildings that include houses, temples, fountains and baths in addition to " +
                                     "agricultural terraces and evidence of an irrigation system.",
                latitude = Machu_lat,
                longitude = Machu_long,
                places = Machu,
                wetherkey = "&q=Machu Picchu"
            };
            List.Add(item);
            MyList[0] = item;

            var item1 = new ListClass
            {
                IconSource = "Panama.png",
                websiteName = "2. Panama Canal, Panama",
                websiteDescription = "Stretching across the Panama Isthmus and regarded as one of the modern-day wonders of the world, " +
                                     "the Panama Canal is a vast and complex canal system built to allow ships passage between the Atlantic " +
                                     "and Pacific Oceans, making it an important channel for international maritime trade. " +
                                     "The Panama Canal is a key source of Panama’s thriving economy and has become a major tourist attraction.",
                latitude = Panama_lat,
                longitude = Panama_long,
                places = Panama,
                wetherkey = "&q=Panama"
            };
            List.Add(item1);
            MyList[1] = item1;

            var item2 = new ListClass
            {
                IconSource = "Rio.png",
                websiteName = "3. Rio de Janeiro, Brazil",
                websiteDescription = "Located in southeastern Brazil, Rio de Janeiro is the most visited city of South America due to its famous mountains, " +
                                     "landmarks, beaches and Carnival festival. Rio de Janeiro is situated on one of the world’s largest " +
                                     "harbors surrounded by natural attractions that include the Sugarloaf and Corcovado mountains and " +
                                     "famous beaches like Copacabana and Ipanema. The city’s iconic landmark is the enormous Christ the Redeemer statue " +
                                     "sitting atop Corcovado mountain. Carnival celebrations here are among the largest in the world, " +
                                     "with vibrant parades, costumes, dancing, music, fireworks and street parties.",
                latitude = Rio_lat,
                longitude = Rio_long,
                places = Rio,
                wetherkey = "&q=Rio"

            };
            List.Add(item2);
            MyList[2] = item2;

            var item3 = new ListClass
            {
                IconSource = "Quito.png",
                websiteName = "4. Quito, Ecuador",
                websiteDescription = "At 2,800 meters (9,350 feet) above sea level, the Ecuadoran capital of Quito is the highest capital " +
                                     "city in the world. This cosmopolitan city of 2.2 million people is located in an active volcano section " +
                                     "of the Andes. Quito has one of the largest and best preserved historic districts in South America. " +
                                     "Founded in 1534, it contains no fewer than 20 Catholic churches from the colonial era and despite intensive restoration, " +
                                     "the old town retains the vibrant working class and indigenous character that has always defined it. " +
                                     "Carondolet Palace, the seat of Ecuador’s government, is located in the historic area.",
                latitude = Quito_lat,
                longitude = Quito_long,
                places = Quito,
                wetherkey = "&q=Quito"
            };
            List.Add(item3);
            MyList[3] = item3;

            var item4 = new ListClass
            {
                IconSource = "Bogota.png",
                websiteName = "5. Bogotá, Colombia",
                websiteDescription = "Bogotá is Colombia’s sprawling, high-altitude capital. La Candelaria, its cobblestoned center," +
                                     "features colonial-era landmarks like the neoclassical performance hall Teatro Colón and the 17th-century" +
                                     "Iglesia de San Francisco. It's also home to popular museums including the Museo Botero, showcasing Fernando Botero's art, and the Museo del Oro, displaying pre-Columbian gold pieces." +
                                     "The Zona Rosa neighborhood is known for upmarket shopping and trendy nightlife." +
                                     "The neighborhoods of Parque de la 93 and La Zona G are lined with more nightclubs," +
                                     "plus gourmet restaurants and high - end hotels.Other notable neighborhoods are La Macarena," +
                                     "with many art galleries, and Usaquén, featuring modern cafes and shops tucked inside colonial relics." +
                                     "One of many green spaces in Bogotá, Simón Bolívar Park offers lakes and walking paths.Reachable via a funicular, the roughly 3, 200m - high Cerro de Monserrate provides panoramic views.It's topped by Santuario de Monserrate, a church famed for its 17th-century shrine.",
                latitude = Bogota_lat,
                longitude = Bogota_long,
                places = Bogota,
                wetherkey = "&q=Bogotá"

            };
            List.Add(item4);
            MyList[4] = item4;

            var item5 = new ListClass
            {
                IconSource = "Santiago.png",
                websiteName = "6. Santiago, Chile",
                websiteDescription = "The capital city is the political and cultural heart of Chile. " +
                                     "From the high mountain views of the Cerro San Cristobal Park to the " +
                                     "secluded history of poet Pablo Neruda’s writing retreat, there is much to see in Santiago. " +
                                     "Top picks include skiing Valle Nevado or Portillo, wine tasting at Vina Aquitania, " +
                                     "or visits to one of several top museums like Museo Chile de Arte Precolumbio or Museo de la Moda. " +
                                     "For those who don’t want to spend all of their time in the city, there are amazing hiking opportunities " +
                                     "like the steep slopes of Cajon de Maipo.",
                latitude = Santiago_lat,
                longitude = Santiago_long,
                places = Santiago,
                wetherkey = "&q=Santiago"
            };
            List.Add(item5);
            MyList[5] = item5;


            SA.ItemsSource = List;
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
