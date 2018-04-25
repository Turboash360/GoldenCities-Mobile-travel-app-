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
    public partial class SingaporeMaps : ContentPage
    {
        public SingaporeMaps()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(1.3521, 103.8125)
                                             , Distance.FromMiles(50));

            SingaporeLocMaps.MoveToRegion(initialMapLocation);


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
                    SingaporeLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(1.2494, 103.8303), Distance.FromMiles(2)));
                    break;
                case (1):
                    SingaporeLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(1.2868, 103.8545), Distance.FromMiles(2)));
                    break;
                case (2):
                    SingaporeLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(1.2893, 103.8631), Distance.FromMiles(2)));
                    break;
                case (3):
                    SingaporeLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(1.2816, 103.8636), Distance.FromMiles(2)));
                    break;
                case (4):
                    SingaporeLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(1.3138, 103.8159), Distance.FromMiles(2)));
                    break;


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Sentosha");
            PointsSelectorSource.Add("Merlion");
            PointsSelectorSource.Add("Singapore Flyer");
            PointsSelectorSource.Add("Garden by the Bay");
            PointsSelectorSource.Add("Botanic Garden");


            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            SingaporeLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            SingaporeLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            SingaporeLocMaps.MapType = MapType.Street;
        }





        private void PlaceAMarker()
        {
            var position = new Position(1.2494, 103.8303);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Sentosa",
                Address = "custom detail info"
            };

            var position2 = new Position(1.2868, 103.8545);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Merlion",
                Address = "custom detail info"
            };

            var position3 = new Position(1.2893, 103.8631);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Singapore Flyer",
                Address = "custom detail info"
            };

            var position4 = new Position(1.2816, 103.8636);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Garden by the Bay",
                Address = "custom detail info"
            };

            var position5 = new Position(1.3138, 103.8159);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Singapore Botanic Gardens",
                Address = "custom detail info"
            };

            SingaporeLocMaps.Pins.Add(pin);
            SingaporeLocMaps.Pins.Add(pin2);
            SingaporeLocMaps.Pins.Add(pin3);
            SingaporeLocMaps.Pins.Add(pin4);
            SingaporeLocMaps.Pins.Add(pin5);
        }
    }
}
