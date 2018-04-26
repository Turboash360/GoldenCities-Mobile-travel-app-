using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace GoldenCities
{
    public partial class ReykjavikMap : ContentPage
    {
        public ReykjavikMap()
        {
            InitializeComponent();
            var initialMapLocation = MapSpan.FromCenterAndRadius
                                (new Position(64.1273, -21.8232)
                                 , Distance.FromMiles(150));

            ReykjavikLocMaps.MoveToRegion(initialMapLocation);


            PlaceAMarker();
            Picker();
        }
        void Handle_IndexChanged(object sender, System.EventArgs e)
        {
            var selector = (Picker)sender;
            int touchIndex = selector.SelectedIndex;

            switch (touchIndex)
            {
                case (0):
                    ReykjavikLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(64.1260, -21.8162), Distance.FromMiles(2)));
                    break;
                case (1):
                    ReykjavikLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(64.1360, -21.8236), Distance.FromMiles(2)));
                    break;
                case (2):
                    ReykjavikLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6129, 77.2295), Distance.FromMiles(2)));
                    break;



            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Tommi's Burger Joint");
            PointsSelectorSource.Add("GeoIceLand Tours");
            PointsSelectorSource.Add("Reykjavik Place 3");


            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            ReykjavikLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            ReykjavikLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            ReykjavikLocMaps.MapType = MapType.Street;
        }
        private void PlaceAMarker()
        {
            var position = new Position(64.1260, -21.8162);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Tommi's Burger Joint",
                Address = "custom detail info"
            };

            var position2 = new Position(64.1360, -21.8236);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "GeoIceLand Tours",
                Address = "custom detail info"
            };

            var position3 = new Position(64.1360, -21.8236);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Golden Circle",
                Address = "custom detail info"
            };

            ReykjavikLocMaps.Pins.Add(pin);
            ReykjavikLocMaps.Pins.Add(pin2);
            ReykjavikLocMaps.Pins.Add(pin3);

        }
    }
}
