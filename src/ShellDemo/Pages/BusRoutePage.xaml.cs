using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellDemo
{
    public partial class BusRoutePage : ContentPage
    {
        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedRoute = e.SelectedItem as BusRouteInfo;

            await Shell.Current.GoToAsync($"busstop?route={selectedRoute.RouteNumber}");

            theListView.SelectedItem = null;
        }

        public BusRoutePage()
        {
            InitializeComponent();
        }
    }
}
