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
    public partial class MadridMap : ContentPage
    {
        public MadridMap()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(40.4175, -3.7046)
                                             , Distance.FromMiles(150));

            MadridLocMaps.MoveToRegion(initialMapLocation);


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
                    MadridLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(40.4577, -3.5432), Distance.FromMiles(2)));
                    break;
                case (1):
                    MadridLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(40.4140, -3.6917), Distance.FromMiles(2)));
                    break;
                case (2):
                    MadridLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(40.4157, -3.7085), Distance.FromMiles(2)));
                    break;
                case (3):
                    MadridLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(40.6601, -4.6886), Distance.FromMiles(2)));
                    break;
                case (4):
                    MadridLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Madrid Marriott Museum");
            PointsSelectorSource.Add("Prado National Museum");
            PointsSelectorSource.Add("Mercado San Miguel");
            PointsSelectorSource.Add("Calle Avila");
            PointsSelectorSource.Add("Royal Palace of Madrid");

            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            MadridLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            MadridLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            MadridLocMaps.MapType = MapType.Street;
        }
        private void PlaceAMarker()
        {
            var position = new Position(40.4577, -3.5432);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Madrid Marriott Museum",
                Address = "custom detail info"
            };

            var position2 = new Position(40.4140, -3.6917);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Prado National Museum",
                Address = "custom detail info"
            };

            var position3 = new Position(40.4157, -3.7085);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Mercado San Miguel",
                Address = "custom detail info"
            };

            var position4 = new Position(40.6601, -4.6886);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Calle Avila",
                Address = "custom detail info"
            };

            var position5 = new Position(40.4182, -3.7142);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Royal Palace of Madrid",
                Address = "custom detail info"
            };

            MadridLocMaps.Pins.Add(pin);
            MadridLocMaps.Pins.Add(pin2);
            MadridLocMaps.Pins.Add(pin3);
            MadridLocMaps.Pins.Add(pin4);
            MadridLocMaps.Pins.Add(pin5);
        }
    }
}
