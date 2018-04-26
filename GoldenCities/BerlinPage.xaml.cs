﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using GoldenCities.ClassModels;
using Xamarin.Forms;

namespace GoldenCities
{
    public partial class BerlinPage : ContentPage
    {
        public BerlinPage()
        {
            InitializeComponent();
        }

        void Handle_ClickedMaps(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BerlinMap());      

        }

        async void Handle_ClickedTemperature(object sender, System.EventArgs e)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(
                string.Format(
                    $"http://api.apixu.com/v1/current.json?key=" +
                    $"{Keys.WeatherForcastKey}" +
                    $"&q=Berlin"));

            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = uri;
            request.Headers.Add("Application", "application / json");

            HttpResponseMessage response = await client.SendAsync(request);

            WeatherForcaster ForcastAPI = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                ForcastAPI = WeatherForcaster.FromJson(content);

                Name.Text = "City: " + ForcastAPI.Location.Name;
                Country.Text = "Country: " + ForcastAPI.Location.Country;
                Time.Text = "Local Time: " + ForcastAPI.Location.Localtime;
                Region.Text = "Region: " + ForcastAPI.Location.Region;
                TemperatureF.Text = "Temperature(F): " + ForcastAPI.Current.TempF;
                TemperatureC.Text = "Temperature(C): " + ForcastAPI.Current.TempC;

            }
        }
    }
}

