using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Europe : ContentPage
    {
        public Europe()
        {
            InitializeComponent();
            PopulateViewList();
        }

        void Handle_ClickedLondon(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LondonPage());
        }

        void Handle_ClickedParis(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ParisPage());
        }

        void Handle_ClickedReykjavik(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ReykjavikPage());
        }

        void Handle_ClickedRome(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RomePage());
        }

        void Handle_ClickedMadrid(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MadridPage());
        }

        void Handle_ClickedBerlin(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BerlinPage());
        }

        private void PopulateViewList()
        {
            var List = new ObservableCollection<ListClass>()
            {
                new ListClass()
                {
                    IconSource= "London.jpeg",
                    websiteName = "1. London, UK",
                    websiteDescription = "Known for Big Ben, London Bridge and the South Bank.  ",
                },

                new ListClass()
                {
                    IconSource="paris.jpg",
                    websiteName = "2. Paris, France",
                    websiteDescription = "Known for the Effel Tower. The best place of romance.",
                },

                new ListClass()
                {
                    IconSource="reykjavik.jpg",
                    websiteName = "3. Iceland",
                    websiteDescription = "Not very well known, but it does have gorgeous scenery. A best place to get fish salmon ",
                },

                new ListClass()
                {
                    IconSource="Rome.jpg",
                    websiteName = "4. Rome, Italy",
                    websiteDescription = "Known for the Leaning Tower of Pisa. It has been leaning like always",
                },

                new ListClass()
                {
                    IconSource="madrid.jpg",
                    websiteName = "5. Madrid, Spain",
                    websiteDescription = "Known for the Royal Palace of Madrid. ",
                },

                new ListClass()
                {
                    IconSource="berlin.jpg",
                    websiteName = "6. Berlin, Germany",
                    websiteDescription = "Known for the Berlin Wall. A nice historical site. ",

                },


            };

            EUR.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var listclass = (ListClass)menuItem.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }

    }
}