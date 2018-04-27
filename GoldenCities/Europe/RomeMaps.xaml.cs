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
    public partial class RomeMap : ContentPage
    {
        public RomeMap()
        {
            InitializeComponent();
            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(41.9036, 12.4930)
                                             , Distance.FromMiles(150));
            RomeLocMaps.MoveToRegion(initialMapLocation);
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
                    RomeLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(41.9067, 12.4536), Distance.FromMiles(2)));
                    break;
                case (1):
                    RomeLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(41.8904, 12.4922), Distance.FromMiles(2)));
                    break;
                case (2):
                    RomeLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(41.8905, 12.4874), Distance.FromMiles(2)));
                    break;
                case (3):
                    RomeLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(41.9032, 12.4544), Distance.FromMiles(2)));
                    break;
                case (4):
                    RomeLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(43.7232, 10.3966), Distance.FromMiles(2)));
                    break;
            }
        }
        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Vatican Museum");
            PointsSelectorSource.Add("Colosseum");
            PointsSelectorSource.Add("Palatine Hill ");
            PointsSelectorSource.Add("Sistine Chapel ");
            PointsSelectorSource.Add("Leaning Tower of Piza");
            PointsSelectors.ItemsSource = PointsSelectorSource;
        }
        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            RomeLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            RomeLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            RomeLocMaps.MapType = MapType.Street;
        }
        private void PlaceAMarker()
        {
            var position = new Position(41.9067, 12.4536);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Vatican Museum",
                Address = "custom detail info"
            };

            var position2 = new Position(41.8904, 12.4922);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Colosseum",
                Address = "custom detail info"
            };

            var position3 = new Position(41.8905, 12.4874);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = " Palatine Hill",
                Address = "custom detail info"
            };

            var position4 = new Position(41.9032, 12.4544);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = " Sistine Chapel  ",
                Address = "custom detail info"
            };

            var position5 = new Position(43.7232, 10.3966);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Leaning Tower of Piza",
                Address = "custom detail info"
            };

            RomeLocMaps.Pins.Add(pin);
            RomeLocMaps.Pins.Add(pin2);
            RomeLocMaps.Pins.Add(pin3);
            RomeLocMaps.Pins.Add(pin4);
            RomeLocMaps.Pins.Add(pin5);
        }
    }
}
