using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace ShellDemo
{
    [QueryProperty("RouteNumber", "route")]
    public partial class BusStopPage : ContentPage
    {
        string routeNumber;
        public string RouteNumber
        {
            set
            {
                int route = int.Parse(value);

                Title = $"Route No {route}";

                BindingContext = new BusStopsData().Where(d => d.RouteNumber == route);

                routeNumber = value;
            }
            get => routeNumber;
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var busStop = e.SelectedItem as BusStopInfo;

            // cannot put a shell visual object onto the stack
            var backRoute = Uri.EscapeDataString(
                $"{Shell.Current.CurrentState.Location.OriginalString}?route={RouteNumber}"
            );

            await Shell.Current.GoToAsync($"//touristsite?showback=true&info={busStop.AttractionName}&backroute={backRoute}");

            theStopsList.SelectedItem = null;
        }

        public BusStopPage()
        {
            InitializeComponent();
        }
    }
}
