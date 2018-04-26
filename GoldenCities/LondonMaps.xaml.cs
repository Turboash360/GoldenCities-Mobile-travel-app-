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
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LondonMaps : ContentPage
    {
        public LondonMaps()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(28.7041, 77.1025)
                                             , Distance.FromMiles(150));

            LondonLocMaps.MoveToRegion(initialMapLocation);


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
                    LondonLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(27.1750, 78.0422), Distance.FromMiles(2)));
                    break;
                case (1):
                    LondonLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(27.1795, 78.0211), Distance.FromMiles(2)));
                    break;
                case (2):
                    LondonLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6129, 77.2295), Distance.FromMiles(2)));
                    break;
                case (3):
                    LondonLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;
                case (4):
                    LondonLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("London Place 1");
            PointsSelectorSource.Add("London Place 2");
            PointsSelectorSource.Add("London Place 3");
            PointsSelectorSource.Add("London Place 4");
            PointsSelectorSource.Add("London Place 5");

            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            LondonLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            LondonLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            LondonLocMaps.MapType = MapType.Street;
        }
        private void PlaceAMarker()
        {
            var position = new Position(27.1750, 78.0422);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "London Place 1",
                Address = "custom detail info"
            };

            var position2 = new Position(27.1795, 78.0211);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "London Place 2",
                Address = "custom detail info"
            };

            var position3 = new Position(28.6129, 77.2295);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "London Place 3",
                Address = "custom detail info"
            };

            var position4 = new Position(28.6562, 77.2410);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "London Place 4",
                Address = "custom detail info"
            };

            var position5 = new Position(28.5535, 78.2588);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "London Place 5",
                Address = "custom detail info"
            };

            LondonLocMaps.Pins.Add(pin);
            LondonLocMaps.Pins.Add(pin2);
            LondonLocMaps.Pins.Add(pin3);
            LondonLocMaps.Pins.Add(pin4);
            LondonLocMaps.Pins.Add(pin5);
        }
    }
}
