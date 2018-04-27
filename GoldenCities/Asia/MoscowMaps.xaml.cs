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
    public partial class MoscowMaps : ContentPage
    {
        public MoscowMaps()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(55.7558, 37.6173)
                                             , Distance.FromMiles(50));

            MoscowLocMaps.MoveToRegion(initialMapLocation);


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
                    MoscowLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(55.7537, 37.6199), Distance.FromMiles(2)));
                    break;
                case (1):
                    MoscowLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(55.7539, 37.6208), Distance.FromMiles(2)));
                    break;
                case (2):
                    MoscowLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(55.7521, 37.6137), Distance.FromMiles(2)));
                    break;
               /* case (3):
                    MoscowLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;
                case (4):
                    MoscowLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;*/


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Lenin's Mausoleum");
            PointsSelectorSource.Add("Red Square");
            PointsSelectorSource.Add("Alexander Garden");
            //PointsSelectorSource.Add("Red Fort");
            //PointsSelectorSource.Add("Lotus Temple");


            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            MoscowLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            MoscowLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            MoscowLocMaps.MapType = MapType.Street;
        }





        private void PlaceAMarker()
        {
            var position = new Position(55.7537, 37.6199);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Lenin's Mausoleum",
                Address = "custom detail info"
            };

            var position2 = new Position(55.7539, 37.6208);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Red Square",
                Address = "custom detail info"
            };

            var position3 = new Position(55.7521, 37.6137);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Alexander Garden",
                Address = "custom detail info"
            };

            /*
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

            MoscowLocMaps.Pins.Add(pin);
            MoscowLocMaps.Pins.Add(pin2);
            MoscowLocMaps.Pins.Add(pin3);
            //MoscowLocMaps.Pins.Add(pin4);
            //MoscowLocMaps.Pins.Add(pin5);
        }
    }
}
