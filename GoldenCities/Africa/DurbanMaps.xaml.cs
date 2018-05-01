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
    public partial class DurbanMaps : ContentPage
    {
        public DurbanMaps()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(-29.8587, 31.0218)
                                             , Distance.FromMiles(150));

            DurbanLocMaps.MoveToRegion(initialMapLocation);


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
                    DurbanLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-29.8673, 31.0459), Distance.FromMiles(2)));
                    break;
                case (1):
                    DurbanLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-29.8086, 31.0174), Distance.FromMiles(2)));
                    break;
                case (2):
                    DurbanLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-29.8479, 31.0082), Distance.FromMiles(2)));
                    break;
                case (3):
                    DurbanLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-29.8354, 31.0346), Distance.FromMiles(2)));
                    break;
                case (4):
                    DurbanLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-29.8290, 31.0304), Distance.FromMiles(2)));
                    break;


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Shaka Marine World");
            PointsSelectorSource.Add("Umgeni River Bird Park");
            PointsSelectorSource.Add("Botanic Gardens");
            PointsSelectorSource.Add("Suncoast Casino and Entertainment World");
            PointsSelectorSource.Add("Moses Mabhida Stadium");


            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            DurbanLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            DurbanLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            DurbanLocMaps.MapType = MapType.Street;
        }





        private void PlaceAMarker()
        {
            var position = new Position(-29.8673, 31.0459);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Shaka Marine World",
                Address = "custom detail info"
            };

            var position2 = new Position(-29.8086, 31.0174);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Umgeni River Bird Park",
                Address = "custom detail info"
            };

            var position3 = new Position(-29.8479, 31.0082);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Botanic Gardens",
                Address = "custom detail info"
            };

            var position4 = new Position(-29.8354, 31.0346);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Suncoast Casino and Entertainment World",
                Address = "custom detail info"
            };

            var position5 = new Position(-29.8290, 31.0304);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Moses Mabhida Stadium",
                Address = "custom detail info"
            };

            DurbanLocMaps.Pins.Add(pin);
            DurbanLocMaps.Pins.Add(pin2);
            DurbanLocMaps.Pins.Add(pin3);
            DurbanLocMaps.Pins.Add(pin4);
            DurbanLocMaps.Pins.Add(pin5);
        }
    }
}
