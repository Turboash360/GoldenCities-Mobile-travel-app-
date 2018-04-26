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
    public partial class ParisMap : ContentPage
    {
        public ParisMap()
        {
            InitializeComponent();
            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(48.8565, 2.3508)
                                             , Distance.FromMiles(150));
            ParisLocMaps.MoveToRegion(initialMapLocation);
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
                    ParisLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(48.8761, 2.3596), Distance.FromMiles(2)));
                    break;
                case (1):
                    ParisLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(48.8849, 2.2999), Distance.FromMiles(2)));
                    break;
                case (2):
                    ParisLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(48.8385, 2.2989), Distance.FromMiles(2)));
                    break;
                case (3):
                    ParisLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(48.8642, 2.3062), Distance.FromMiles(2)));
                    break;
                case (4):
                    ParisLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(48.8798, 2.3298), Distance.FromMiles(2)));
                    break;
            }
        }
        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("St. Vincient de Paul");
            PointsSelectorSource.Add("75 St. Rue");
            PointsSelectorSource.Add(" Bob's Hotel");
            PointsSelectorSource.Add(" Effel Tower");
            PointsSelectorSource.Add(" St. Georges");
            PointsSelectors.ItemsSource = PointsSelectorSource;
        }
        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            ParisLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            ParisLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            ParisLocMaps.MapType = MapType.Street;
        }
        private void PlaceAMarker()
        {
            var position = new Position(27.1750, 78.0422);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "St. Vincient de Paul ",
                Address = "custom detail info"
            };

            var position2 = new Position(27.1795, 78.0211);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "75 St. Rue ",
                Address = "custom detail info"
            };

            var position3 = new Position(28.6129, 77.2295);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Bob's Hotel ",
                Address = "custom detail info"
            };

            var position4 = new Position(28.6562, 77.2410);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Effel Tower ",
                Address = "custom detail info"
            };

            var position5 = new Position(28.5535, 78.2588);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "St. Georges ",
                Address = "custom detail info"
            };

            ParisLocMaps.Pins.Add(pin);
            ParisLocMaps.Pins.Add(pin2);
            ParisLocMaps.Pins.Add(pin3);
            ParisLocMaps.Pins.Add(pin4);
            ParisLocMaps.Pins.Add(pin5);
        }
    }
}
