using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Asia : ContentPage
    {
        public Asia()
        {
            InitializeComponent();
            PopulateViewList();
        }

        void Handle_Clicked_Delhi(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DelhiPage());
        }

        void Handle_Clicked_Male(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MalePage());
        }

        void Handle_Clicked_Dubai(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DubaiPage());
        }

        void Handle_Clicked_Singapore(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SingaporePage());
        }

        void Handle_Clicked_KualaLumpur(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new KualaLumpurPage());
        }

        void Handle_Clicked_Tokyo(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TokyoPage());
        }

        void Handle_Clicked_Moscow(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MoscowPage());
        }

        public void PopulateViewList()
        {
            var List = new ObservableCollection<ListClass>()
            {
                new ListClass()
                {
                    IconSource = "Taj_Mahal.png",
                    websiteName = "1. Delhi/Agra, India",
                    websiteDescription = "India's capital and major gateway of the country, " +
                        "contemporary Delhi is bustling metropolis, which successfully " +
                        "combines in its fold the ancient and the modern. Its strategic " +
                        "location was one of the prime reasons why successive dynasties " +
                        "chose it as their seat of power. It is one of the most populates" +
                        "city in the world and also in India. There are some wonderful tourist attractions" +
                        "such as Taj Mahal. ", 
                },

                new ListClass()
                {
                    IconSource = "Maldives.png",
                    websiteName = "2. Male, Maldives",
                    websiteDescription = "The isolated city in the island of Maldives, off coast of the Indian" +
                        "Ocean where there is enjoyable time in doin watersports activities.",
                },

                new ListClass()
                {
                    IconSource = "Dubai.png",
                    websiteName = "3. Dubai, UAE",
                    websiteDescription = "One of the most luxurious cities in the Arabian Peninsula." +
                        "Most of the tourist from all over the world come to this city to visit this artificial" +
                        "futuristic city.",
                },

                new ListClass()
                {
                    IconSource = "Singapore.png",
                    websiteName = "4. Singapore, Singapore",
                    websiteDescription = "One of the luxurious cities in South East Asia. Tourist come here to" +
                        "visit the merilion, and the sentosa islands. ",
                },

                new ListClass()
                {
                    IconSource = "Kuala_Lumpur.png",
                    websiteName = "5. Kuala Lumpur, Malaysia",
                    websiteDescription = "Another city in south east asia.  ",
                },

                new ListClass()
                {
                    IconSource = "Tokyo.png",
                    websiteName = "6. Tokyo, Japan",
                    websiteDescription = "The most well known city in Japan and also the capital city.",
                },

                new ListClass()
                {

                    IconSource = "Moscow.png",
                    websiteName = "7. Moscow, Russia",
                    websiteDescription = "The most well known city in Russia and also the capital city.",


                },
            };

            AS.ItemsSource = List;

        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var listclass = (ListClass)menuItem.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }

    }
}
