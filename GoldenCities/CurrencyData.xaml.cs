using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using GoldenCities.ClassModels;
using Xamarin.Forms;

namespace GoldenCities
{
    public partial class CurrencyData : ContentPage
    {
        public CurrencyData()
        {
            InitializeComponent();
        }

        async void Handle_ClickedCurrency(object sender, System.EventArgs e)
        {

            HttpClient client = new HttpClient();

            var uri = new Uri(
                string.Format(
                    $"http://www.apilayer.net/api/live?access_key=" +
                    $"{TransKeys.CurrencyKey}"
                    ));


            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = uri;
            request.Headers.Add("Application", "application / json");

            HttpResponseMessage response = await client.SendAsync(request);

            Currency Money = null;

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Money = Currency.FromJson(content);
                Source.Text = Money.Source;
                /*
                 * Anyone please help me with the quotes list
                foreach(var i in Money.Quotes)
                {
                    Quotes.Text = Money[i].Quotes;
                        
                }*/

            }

        }

    }
}
