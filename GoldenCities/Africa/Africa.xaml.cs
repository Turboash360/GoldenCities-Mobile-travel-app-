﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class Africa : ContentPage
    {
        public Africa()
        {
            InitializeComponent();
            PopulateViewList();
        }

        private void PopulateViewList()
        {
            var List = new ObservableCollection<ListClass>()
            {
                new ListClass()
                {
                    websiteName = "Cairo, Egypt",
                    websiteDescription = "It's the capital of Egypt.It's the largest city in Egypt, and" +
                        "also the 15th largest city in the world.",
                },

                new ListClass()
                {
                    websiteName = "Seychelles",
                    websiteDescription = "It's a republic in France, and one of the sovereign states" +
                        "in the Indian Ocean.",
                },

                new ListClass()
                {
                    websiteName = "Durban, South Africa",
                    websiteDescription = "Located on east coast of South Africa, and one of the largest cities.",
                },

                new ListClass()
                {
                    websiteName = "Adidas Ababa, Ethopia",
                    websiteDescription = "It's the capital of Ethiopia."
                }
            };

            AFR.ItemsSource = List;
        }

        void HandleMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var listclass = (ListClass)menuItem.CommandParameter;
            Navigation.PushAsync(new TravelMoreInfo(listclass));
        }

    }
}