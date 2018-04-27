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
    public partial class TokyoMaps : ContentPage
    {
        public TokyoMaps()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(35.6895, 139.6917)
                                             , Distance.FromMiles(70));

            TokyoLocMaps.MoveToRegion(initialMapLocation);


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
                    TokyoLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(35.7101, 139.8107), Distance.FromMiles(2)));
                    break;
                case (1):
                    TokyoLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(35.6586, 139.7454), Distance.FromMiles(2)));
                    break;
                case (2):
                    TokyoLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(35.3606, 138.7278), Distance.FromMiles(2)));
                    break;
                case (3):
                    TokyoLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(35.6852, 139.7101), Distance.FromMiles(2)));
                    break;
               /* case (4):
                    TokyoLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;*/


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Skytree");
            PointsSelectorSource.Add("Tokyo Tower");
            PointsSelectorSource.Add("Mount Fuji");
            PointsSelectorSource.Add("Shinjuku Gyo-en");
            //PointsSelectorSource.Add("Lotus Temple");


            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            TokyoLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            TokyoLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            TokyoLocMaps.MapType = MapType.Street;
        }





        private void PlaceAMarker()
        {
            var position = new Position(35.7101, 139.8107);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Skytree",
                Address = "custom detail info"
            };

            var position2 = new Position(35.6586, 139.7454);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Tokyo Tower",
                Address = "custom detail info"
            };

            var position3 = new Position(35.3606, 138.7278);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Mount Fuji",
                Address = "custom detail info"
            };

            var position4 = new Position(35.6852, 139.7101);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Shinjuku Gyo-en",
                Address = "custom detail info"
            };

            /*
            var position5 = new Position(28.5535, 78.2588);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Lotus Temple",
                Address = "custom detail info"
            };*/

            TokyoLocMaps.Pins.Add(pin);
            TokyoLocMaps.Pins.Add(pin2);
            TokyoLocMaps.Pins.Add(pin3);
            TokyoLocMaps.Pins.Add(pin4);
            //TokyoLocMaps.Pins.Add(pin5);
        }
    }
}
