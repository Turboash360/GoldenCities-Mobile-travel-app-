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


                //This will display all the string content
                //----------------------------------------------------------------
                Dictionary<string, double> pairs = Money.Quotes;

                int size = pairs.Keys.Count;  //Size of the quotes

                string[] keys = new string[size]; //Make array with the same size
                pairs.Keys.CopyTo(keys, 0);    //Input all the string values into a string array

                for (int i = 0; i < size; i++)
                {
                    Quotes.Text += " " + keys[i];  // Print each string value
                }
                //----------------------------------------------------------------------


                //Make another array for the double vaules 
                //________________________________________________________
                double[] value = new double[size];
                pairs.Values.CopyTo(value, 0);
                //.............//
                //to display content you must turn double value into a string 


                //Note size of array is large must find better way to organize




               
            }

        }

    }
}
