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
    public partial class SeychellesMaps : ContentPage
    {
        public SeychellesMaps()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(-4.6796, 55.4920)
                                             , Distance.FromMiles(150));

            SeychellesLocMaps.MoveToRegion(initialMapLocation);


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
                    SeychellesLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-4.6827, 55.4804), Distance.FromMiles(2)));
                    break;
                case (1):
                    SeychellesLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-4.6191, 55.4513), Distance.FromMiles(2)));
                    break;
                case (2):
                    SeychellesLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-4.6211, 55.4278), Distance.FromMiles(2)));
                    break;
                case (3):
                    SeychellesLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-4.3591, 55.8412), Distance.FromMiles(2)));
                    break;
                


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Mahe");
            PointsSelectorSource.Add("Victoria");
            PointsSelectorSource.Add("Beau Vallon");
            PointsSelectorSource.Add("La Digue");
           


            PointsSelectors.ItemsSource = PointsSelectorSource;


        }



        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            SeychellesLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            SeychellesLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            SeychellesLocMaps.MapType = MapType.Street;
        }





        private void PlaceAMarker()
        {
            var position = new Position(-4.6827, 55.4804);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Mahe",
                Address = "custom detail info"
            };

            var position2 = new Position(-4.6191, 55.4513);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Victoria",
                Address = "custom detail info"
            };

            var position3 = new Position(-4.6211, 55.4278);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Beau Vallon",
                Address = "custom detail info"
            };

            var position4 = new Position(-4.3591, 55.8412);
            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "La Digue",
                Address = "custom detail info"
            };

           

            SeychellesLocMaps.Pins.Add(pin);
            SeychellesLocMaps.Pins.Add(pin2);
            SeychellesLocMaps.Pins.Add(pin3);
            SeychellesLocMaps.Pins.Add(pin4);

        }
    }
}
