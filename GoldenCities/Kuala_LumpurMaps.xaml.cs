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
    public partial class Kuala_LumpurMaps : ContentPage
    {
        public Kuala_LumpurMaps()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(3.1390, 101.6869)
                                             , Distance.FromMiles(50));

            Kuala_LumpurLocMaps.MoveToRegion(initialMapLocation);


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
                    Kuala_LumpurLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(3.2379, 101.6840), Distance.FromMiles(2)));
                    break;
                case (1):
                    Kuala_LumpurLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(3.1578, 101.7119), Distance.FromMiles(2)));
                    break;
                case (2):
                    Kuala_LumpurLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(3.4237, 101.7938), Distance.FromMiles(2)));
                    break;
               
                /*case (3):
                    Kuala_LumpurLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;
                case (4):
                    Kuala_LumpurLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;*/


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Batu Caves");
            PointsSelectorSource.Add("Petronas Tower");
            PointsSelectorSource.Add("Genting Highlands");
            //PointsSelectorSource.Add("Red Fort");
            //PointsSelectorSource.Add("Lotus Temple");


            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            Kuala_LumpurLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            Kuala_LumpurLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            Kuala_LumpurLocMaps.MapType = MapType.Street;
        }





        private void PlaceAMarker()
        {
            var position = new Position(3.2379, 101.6840);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Batu Caves",
                Address = "custom detail info"
            };

            var position2 = new Position(3.1578, 101.7119);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Petronas Tower",
                Address = "custom detail info"
            };

            var position3 = new Position(3.4237,101.7938);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Genting Highlands",
                Address = "custom detail info"
            };

            /*var position4 = new Position(28.6562, 77.2410);
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

            Kuala_LumpurLocMaps.Pins.Add(pin);
            Kuala_LumpurLocMaps.Pins.Add(pin2);
            Kuala_LumpurLocMaps.Pins.Add(pin3);
            //Kuala_LumpurLocMaps.Pins.Add(pin4);
            //Kuala_LumpurLocMaps.Pins.Add(pin5);
        }
    }
}
