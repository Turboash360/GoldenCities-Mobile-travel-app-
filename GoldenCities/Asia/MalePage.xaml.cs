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

        void Handle_ClickedMaps(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MaleMapsPage());
        }


        async void Handle_ClickedTemperature(object sender, System.EventArgs e)
        {
            HttpClient client = new HttpClient();

            var uri = new Uri(
                string.Format(
                    $"http://api.apixu.com/v1/current.json?key=" +
                    $"{Keys.WeatherForcastKey}" +
                    $"&q=Malé"));

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

                /*TimeZone.Text = "TimeZone: " + ForcastAPI.Timezone;
                //Time.Text = "Local Time: " + ForcastAPI.Daily.Data[0].SunriseTime;
                TemperatureF.Text = "Actual Temperature: " + ForcastAPI.Currently.Temperature + " Farenheit";
                TemperatureC.Text = "Feels Like: " + ForcastAPI.Currently.ApparentTemperature + " Farenheit";
                //Humidity.Text = "Humidity: " + ForcastAPI.Currently.Humidity;
                //WindSpeed.Text = "WindSpeed: " + ForcastAPI.Currently.WindSpeed + " " + ForcastAPI.Currently.WindGust;
                //TempData = $"Current temperature in Delhi is {ForcastAPI.Daily.Data}";*/
            }
        }

    }
}
