using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GoldenCities
{
    public partial class UserList : ContentPage
    {
        public UserList()
        {
            InitializeComponent();
            this.Title = "User List";

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            UserListView.ItemsSource = await App.Database.GetUserAsync();
        }


    }
}
