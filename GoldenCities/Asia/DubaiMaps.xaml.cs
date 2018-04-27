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
                                             , Distance.FromMiles(50));

            DubaiLocMaps.MoveToRegion(initialMapLocation);

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
                    DubaiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(25.1750, 55.2708), Distance.FromMiles(2)));
                    break;
                case (1):
                    DubaiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(25.1304, 55.1171), Distance.FromMiles(2)));
                    break;
                case (2):
                    DubaiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(25.1336, 55.1204), Distance.FromMiles(2)));
                    break;
                case (3):
                    DubaiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(25.1974, 55.2791), Distance.FromMiles(2)));
                    break;
                case (4):
                    DubaiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(25.1319, 55.1184), Distance.FromMiles(2)));
                    break;


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Dubai The Golden City");
            PointsSelectorSource.Add("Atlantis Hotel");
            PointsSelectorSource.Add("Aquaventure WaterPark");
            PointsSelectorSource.Add("Dubai Underwater Aquarium");
            PointsSelectorSource.Add("Lost Chambers Aquarium");


            PointsSelectors.ItemsSource = PointsSelectorSource;


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

           var position2 = new Position(25.1304, 55.1171);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Atlantis Hotel",
                Address = "The Best hotel in Dubai. Luxurious time to be spent relaxing."
            };


            var position3 = new Position(25.1336, 55.1204);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Aquaventure WaterPark",
                Address = "custom detail info"
            };


            var position4 = new Position(25.1974, 55.2791);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Dubai Underwater Aquarium",
                Address = "custom detail info"
            };


            var position5 = new Position(25.1319, 55.1184);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Lost Chambers Aquarium",
                Address = "custom detail info"
            };

            DubaiLocMaps.Pins.Add(pin);
            DubaiLocMaps.Pins.Add(pin2);
            DubaiLocMaps.Pins.Add(pin3);
            DubaiLocMaps.Pins.Add(pin4);
            DubaiLocMaps.Pins.Add(pin5);
        }

    }
}
