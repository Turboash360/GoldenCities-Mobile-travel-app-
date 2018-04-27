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
    public partial class BerlinMap : ContentPage
    {
        public BerlinMap()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(52.5504, 13.3931)
                                             , Distance.FromMiles(150));

            BerlinLocMaps.MoveToRegion(initialMapLocation);


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
                    BerlinLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(52.5504, 13.3931), Distance.FromMiles(2)));
                    break;
                case (1):
                    BerlinLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(52.5188, 13.3763), Distance.FromMiles(2)));
                    break;
                case (2):
                    BerlinLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(52.5213, 13.3969), Distance.FromMiles(2)));
                    break;
                case (3):
                    BerlinLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(52.5054, 13.4396), Distance.FromMiles(2)));
                    break;
                case (4):
                    BerlinLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(52.5165, 13.3779), Distance.FromMiles(2)));
                    break;
            }
        }

        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;
            var PointsSelectorSource = new ObservableCollection<string>();
            PointsSelectorSource.Add("Berlin Wall");
            PointsSelectorSource.Add("Reichstag Building");
            PointsSelectorSource.Add("Pergamon Museum");
            PointsSelectorSource.Add("East Side Gallery");
            PointsSelectorSource.Add("Brandenburg Gate");
            PointsSelectors.ItemsSource = PointsSelectorSource;
        }
        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            BerlinLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            BerlinLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            BerlinLocMaps.MapType = MapType.Street;
        }
        private void PlaceAMarker()
        {
            var position = new Position(52.5504, 13.3931);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Berlin Wall ",
                Address = "custom detail info"
            };

            var position2 = new Position(52.5188, 13.3763);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Reichstag Building",
                Address = "custom detail info"
            };

            var position3 = new Position(52.5213, 13.3969);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Pergamon Museum",
                Address = "custom detail info"
            };

            var position4 = new Position(52.5054, 13.4396);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "East Side Gallery",
                Address = "custom detail info"
            };

            var position5 = new Position(52.5165, 13.3779);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Brandenburg Gate",
                Address = "custom detail info"
            };

            BerlinLocMaps.Pins.Add(pin);
            BerlinLocMaps.Pins.Add(pin2);
            BerlinLocMaps.Pins.Add(pin3);
            BerlinLocMaps.Pins.Add(pin4);
            BerlinLocMaps.Pins.Add(pin5);
        }
    }
}
