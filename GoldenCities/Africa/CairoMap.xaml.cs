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
    public partial class CairoMaps : ContentPage
    {
        public CairoMaps()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(30.0444, 31.2357)
                                             , Distance.FromMiles(150));

            CairoLocMaps.MoveToRegion(initialMapLocation);


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
                    CairoLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.9792, 31.1342), Distance.FromMiles(2)));
                    break;
                case (1):
                    CairoLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(30.0406, 31.2647), Distance.FromMiles(2)));
                    break;
                case (2):
                    CairoLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.5216, 31.125897), Distance.FromMiles(2)));
                    break;
                case (3):
                    CairoLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(30.0478, 31.2336), Distance.FromMiles(2)));
                    break;
                case (4):
                    CairoLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(29.9753, 31.1376), Distance.FromMiles(2)));
                    break;


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Pyramids of Giza");
            PointsSelectorSource.Add("Al Azhar Park");
            PointsSelectorSource.Add("Saqqara");
            PointsSelectorSource.Add("Egyptian Muesuem");
            PointsSelectorSource.Add("Sphinx");


            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            CairoLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            CairoLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            CairoLocMaps.MapType = MapType.Street;
        }





        private void PlaceAMarker()
        {
            var position = new Position(29.9792, 31.1342);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Pyramids Of Giza",
                Address = "custom detail info"
            };

            var position2 = new Position(30.0406, 31.2647);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Al Azhar Park",
                Address = "custom detail info"
            };

            var position3 = new Position(29.5216, 31.125897);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Saqqara",
                Address = "custom detail info"
            };

            var position4 = new Position(30.0478, 31.2336);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Egyptian Muesuem",
                Address = "custom detail info"
            };

            var position5 = new Position(29.9753, 31.1376);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Sphinx",
                Address = "custom detail info"
            };

            CairoLocMaps.Pins.Add(pin);
            CairoLocMaps.Pins.Add(pin2);
            CairoLocMaps.Pins.Add(pin3);
            CairoLocMaps.Pins.Add(pin4);
            CairoLocMaps.Pins.Add(pin5);
        }
    }
}
