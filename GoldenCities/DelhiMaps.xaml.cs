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
    public partial class DelhiMaps : ContentPage
    {
        public DelhiMaps()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(28.7041, 77.1025)
                                             , Distance.FromMiles(150));

            DelhiLocMaps.MoveToRegion(initialMapLocation);


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
                    DelhiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(27.1750, 78.0422), Distance.FromMiles(2)));
                    break;
                case (1):
                    DelhiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(27.1795, 78.0211), Distance.FromMiles(2)));
                    break;
                case (2):
                    DelhiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6129, 77.2295), Distance.FromMiles(2)));
                    break;
                case (3):
                    DelhiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;
                case (4):
                    DelhiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;
               

            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Taj Mahal");
            PointsSelectorSource.Add("Agra Fort");
            PointsSelectorSource.Add("India Gate");
            PointsSelectorSource.Add("Red Fort");
            PointsSelectorSource.Add("Lotus Temple");
           

            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            DelhiLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            DelhiLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            DelhiLocMaps.MapType = MapType.Street;
        }





        private void PlaceAMarker()
        {
            var position = new Position(27.1750, 78.0422);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Taj Mahal",
                Address = "custom detail info"
            };

            var position2 = new Position(27.1795, 78.0211);
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
            };

            DelhiLocMaps.Pins.Add(pin);
            DelhiLocMaps.Pins.Add(pin2);
            DelhiLocMaps.Pins.Add(pin3);
            DelhiLocMaps.Pins.Add(pin4);
            DelhiLocMaps.Pins.Add(pin5);
        }
    }
}
