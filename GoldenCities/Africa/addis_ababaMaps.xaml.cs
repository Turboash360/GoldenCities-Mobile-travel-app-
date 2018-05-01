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
    public partial class addis_ababaMaps : ContentPage
    {
        public addis_ababaMaps()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(8.9806, 38.7578)
                                             , Distance.FromMiles(150));

            addis_ababaLocMaps.MoveToRegion(initialMapLocation);


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
                    addis_ababaLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(9.0303, 38.7664), Distance.FromMiles(2)));
                    break;
                case (1):
                    addis_ababaLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(8.6305, 38.5020), Distance.FromMiles(2)));
                    break;
                case (2):
                    addis_ababaLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(9.1156, 38.7722), Distance.FromMiles(2)));
                    break;
                case (3):
                    addis_ababaLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(11.7559, 40.9587), Distance.FromMiles(2)));
                    break;
                case (4):
                    addis_ababaLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(12.0266, 37.3035), Distance.FromMiles(2)));
                    break;


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Holy Trinity Cathedral");
            PointsSelectorSource.Add("Adadi Mariyam");
            PointsSelectorSource.Add("Mt.Entoto");
            PointsSelectorSource.Add("Afar Region");
            PointsSelectorSource.Add("Lake Tana");


            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            addis_ababaLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            addis_ababaLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            addis_ababaLocMaps.MapType = MapType.Street;
        }





        private void PlaceAMarker()
        {
            var position = new Position(9.0303, 38.7664);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Holy Trinity Cathedral",
                Address = "custom detail info"
            };

            var position2 = new Position(8.6305, 38.5020);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Adadi Mariyam",
                Address = "custom detail info"
            };

            var position3 = new Position(9.1156, 38.7722);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Mt.Entoto",
                Address = "custom detail info"
            };

            var position4 = new Position(11.7559, 40.9587);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Afar Region",
                Address = "custom detail info"
            };

            var position5 = new Position(12.0266, 37.3035);
            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Lake Tana",
                Address = "custom detail info"
            };

            addis_ababaLocMaps.Pins.Add(pin);
            addis_ababaLocMaps.Pins.Add(pin2);
            addis_ababaLocMaps.Pins.Add(pin3);
            addis_ababaLocMaps.Pins.Add(pin4);
            addis_ababaLocMaps.Pins.Add(pin5);
        }
    }
}
