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
                    websiteName = "1. Delhi/Agra, India",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "2. Male, Maldives",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "3. Dubai, UAE",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "4. Singapore, Singapore",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "5. Kuala Lumpur, Malaysia",
                    websiteDescription = "H",
                },

                new ListClass()
                {
                    websiteName = "6. Tokyo, Japan",
                    websiteDescription = "The most well known city in Japan and also the capital city.",
                },

                new ListClass()
                {
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
