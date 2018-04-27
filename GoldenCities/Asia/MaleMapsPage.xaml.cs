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
    public partial class MaleMapsPage : ContentPage
    {
        public MaleMapsPage()
        {
            InitializeComponent();

            var initialMapLocation = MapSpan.FromCenterAndRadius
                                            (new Position(4.1755, 73.5093)
                                             , Distance.FromMiles(1));

            MaleLocMaps.MoveToRegion(initialMapLocation);

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
                    MaleLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(4.1755, 73.5093), Distance.FromMiles(2)));
                    break;
                case (1):
                    MaleLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(5.2396, 72.9933), Distance.FromMiles(2)));
                    break;
                case (2):
                    MaleLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(4.4533, 73.7169), Distance.FromMiles(2)));
                    break;
                /*case (3):
                    DelhiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;
                case (4):
                    DelhiLocMaps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(28.6562, 77.2410), Distance.FromMiles(2)));
                    break;*/


            }
        }


        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            PointsSelectorSource.Add("Male, Maldives");
            PointsSelectorSource.Add("Baa Atoll");
            PointsSelectorSource.Add("Meeru Island");



            PointsSelectors.ItemsSource = PointsSelectorSource;


        }




        void Handle_ClickedHybrid(object sender, System.EventArgs e)
        {
            MaleLocMaps.MapType = MapType.Hybrid;
        }

        void Handle_ClickedSatellight(object sender, System.EventArgs e)
        {
            MaleLocMaps.MapType = MapType.Satellite;
        }

        void Handle_ClickedStreet(object sender, System.EventArgs e)
        {
            MaleLocMaps.MapType = MapType.Street;
        }



        private void PlaceAMarker()
        {
            var position = new Position(4.1755, 73.5093);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Male",
                Address = "Maldives"

            };

            var position2 = new Position(5.2396, 72.9933);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Baa Atoll",
                Address = "Label",
            }; 


            var position3 = new Position(4.4533, 73.7169);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Meeru Island",
                Address = "An island surrounded by beautiful lagoon with long stretches of white sandy beach",
            };



            MaleLocMaps.Pins.Add(pin);
            MaleLocMaps.Pins.Add(pin2);
            MaleLocMaps.Pins.Add(pin3);

        }


    }
}
