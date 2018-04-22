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
    public partial class MaleMapsPage : ContentPage
    {
        public MaleMapsPage()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(4.1755, 73.5093)
                                             , Distance.FromMiles(1));

            MaleLocMaps.MoveToRegion(initialMapLocation);

        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            MaleLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            MaleLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            MaleLocMaps.MapType = MapType.Street;
        }



        private void PlaceAMarker()
        {
            var position = new Position(4.1755, 73.5093);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Male",
                Address = "Maldives"

            };

            MaleLocMaps.Pins.Add(pin);

        }


    }
}
