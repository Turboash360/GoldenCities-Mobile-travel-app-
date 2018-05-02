using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoldenCities.ClassModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace GoldenCities.InfoOnCites
{
    
    public partial class CitiesMap : ContentPage
    {
        ListClass MyList;
        public CitiesMap()
        {
            InitializeComponent();
        }
        public CitiesMap(ListClass listclass)
        {
            InitializeComponent();
            BindingContext = listclass;
            MyList = listclass;
            var initialMapLocation = MapSpan.FromCenterAndRadius(new Position(MyList.latitude[0], MyList.longitude[0]), Distance.FromMiles(50));

            City_Map.MoveToRegion(initialMapLocation);
            PlaceAMarker();
            Picker();
        }

        void Handle_IndexChanged(object sender, System.EventArgs e)
        {
            var selector = (Picker)sender;
            int touchIndex = selector.SelectedIndex;

            City_Map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(MyList.latitude[touchIndex], MyList.longitude[touchIndex]), Distance.FromMiles(2)));
        }

        private void Picker()
        {
            PointsSelectors.SelectedIndex = 0;

            var PointsSelectorSource = new ObservableCollection<string>();

            for (int i = 0; i < MyList.places.Length; i++)
            {
                PointsSelectorSource.Add(MyList.places[i]);
            }

            PointsSelectors.ItemsSource = PointsSelectorSource;
        }

        void Handle_ClickedMapChange(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "Street")
            {
                City_Map.MapType = MapType.Street;
            }
            else if (button.Text == "Satellite")
            {
                City_Map.MapType = MapType.Satellite;
            }
            else if (button.Text == "Hybrid")
            {
                City_Map.MapType = MapType.Hybrid;
            }
        }

        private void PlaceAMarker()
        {
            Position[] position = new Position[MyList.places.Length];
            Pin[] pins = new Pin[MyList.places.Length];

            for (int i = 0; i < MyList.places.Length; i++)
            {
                position[i] = new Position(MyList.latitude[i], MyList.longitude[i]);
                pins[i] = new Pin
                {
                    Type = PinType.Place,
                    Position = position[i],
                    Label = MyList.places[i],
                    Address = "custom detail info",
                };
                City_Map.Pins.Add(pins[i]);
            }
        }
    }
}