using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using GoldenCities.ClassModels;
using Xamarin.Forms;

namespace GoldenCities
{
    public partial class MalePage : ContentPage
    {
        public MalePage()
        {
            InitializeComponent();
        }


        async void Handle_ClickedTemperature(object sender, System.EventArgs e)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(
                string.Format(
                    $"https://api.darksky.net/forecast/" +
                    $"{Keys.WeatherForcastKey}" +
                    $"/4.1754959,73.509347"));

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
                TimeZone.Text = "TimeZone: " + ForcastAPI.Timezone;
                //Time.Text = "Local Time: " + ForcastAPI.Daily.Data[0].SunriseTime;
                TemperatureF.Text = "Actual Temperature: " + ForcastAPI.Currently.Temperature + " Farenheit";
                TemperatureC.Text = "Feels Like: " + ForcastAPI.Currently.ApparentTemperature + " Farenheit";
                //Humidity.Text = "Humidity: " + ForcastAPI.Currently.Humidity;
                //WindSpeed.Text = "WindSpeed: " + ForcastAPI.Currently.WindSpeed + " " + ForcastAPI.Currently.WindGust;
                //TempData = $"Current temperature in Delhi is {ForcastAPI.Daily.Data}";
            }
        }

    }
}
