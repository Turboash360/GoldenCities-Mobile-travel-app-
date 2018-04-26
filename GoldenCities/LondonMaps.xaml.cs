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
                                            (new Position(51.5106, -0.1280)
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
                    LondonLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(51.5037, -0.1246), Distance.FromMiles(2)));
                    break;
                case (1):
                    LondonLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(51.4991, -0.1079), Distance.FromMiles(2)));
                    break;
                case (2):
                    LondonLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(51.5146, -0.1172), Distance.FromMiles(2)));
                    break;
                case (3):
                    LondonLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(51.4994, -0.0999), Distance.FromMiles(2)));
                    break;
                case (4):
                    LondonLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(51.5143, -0.1303), Distance.FromMiles(2)));
                    break;
            }
        }
        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Big Ben ");
            PointsSelectorSource.Add("South Bank ");
            PointsSelectorSource.Add("London Transport Museum ");
            PointsSelectorSource.Add("Imperial War Museum ");
            PointsSelectorSource.Add("London Square");

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
            var position = new Position(51.5037, -0.1246);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Big Ben",
                Address = "custom detail info"
            };

            var position2 = new Position(51.4991, -0.1079);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "South Bank",
                Address = "custom detail info"
            };

            var position3 = new Position(51.5146, -0.1172);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "London Transport Museum",
                Address = "custom detail info"
            };

            var position4 = new Position(51.4994, -0.0999);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Imperial War Museum",
                Address = "custom detail info"
            };

            var position5 = new Position(51.5143, -0.1303);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "London Square",
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
