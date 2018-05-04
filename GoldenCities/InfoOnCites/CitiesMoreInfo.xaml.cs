using System;
using System.Collections.Generic;
using System.Net.Http;
using Plugin.Connectivity;
using GoldenCities.ClassModels;
using Xamarin.Forms;

namespace GoldenCities.InfoOnCites
{
    public partial class CitiesMoreInfo : ContentPage
    {
        ListClass MyList;
        public CitiesMoreInfo()
        {
            InitializeComponent();
        }
        public CitiesMoreInfo(ListClass listclass)
        {
            InitializeComponent();
            MyList = listclass;
            welcome.Text = MyList.websiteName;
        }

        void Handle_ClickedMaps(object sender, System.EventArgs e)
        {
            if (CrossConnectivity.Current.IsConnected != true)
            {
                DisplayAlert("Wifi Connection Status", "No Service you are not connected to Wifi", "Try Again");
            }
            else
            {
                Navigation.PushAsync(new CitiesMap(MyList));
            }
        }

        async void Handle_ClickedTemperature(object sender, System.EventArgs e)
        {

            if (CrossConnectivity.Current.IsConnected != true)
            {
                await DisplayAlert("Wifi Connection Status", "No Service you are not connected to Wifi", "Try Again");
            }
            else
            {
                HttpClient client = new HttpClient();

                var uri = new Uri(
                    string.Format(
                        $"http://api.apixu.com/v1/current.json?key=" +
                        $"{TransKeys.WeatherForcastKey}" +
                        $"{MyList.wetherkey}"));

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
}
