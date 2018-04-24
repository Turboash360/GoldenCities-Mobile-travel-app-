using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace GoldenCities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DubaiMaps : ContentPage
    {
        public DubaiMaps()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(25.2048, 55.2708)
                                             , Distance.FromMiles(150));

            DubaiLocMaps.MoveToRegion(initialMapLocation);

            PlaceAMarker();

        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            DubaiLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            DubaiLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            DubaiLocMaps.MapType = MapType.Street;
        }


        private void PlaceAMarker()
        {
            var position = new Position(25.1750, 55.2708);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Dubai",
                Address = "custom detail info"
            };

           /* var position2 = new Position(27.1795, 78.0211);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Agra Fort",
                Address = "custom detail info"
            };

            var position3 = new Position(28.6129, 77.2295);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "India Gate",
                Address = "custom detail info"
            };

            var position4 = new Position(28.6562, 77.2410);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Red Fort",
                Address = "custom detail info"
            };

            var position5 = new Position(28.5535, 78.2588);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Lotus Temple",
                Address = "custom detail info"
            };*/

            DubaiLocMaps.Pins.Add(pin);
           // DelhiLocMaps.Pins.Add(pin2);
           // DelhiLocMaps.Pins.Add(pin3);
           // DelhiLocMaps.Pins.Add(pin4);
           // DelhiLocMaps.Pins.Add(pin5);
        }

    }
}
