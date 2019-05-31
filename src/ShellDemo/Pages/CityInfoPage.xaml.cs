using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellDemo
{
    public partial class CityInfoPage : ContentPage
    {
        public CityInfoPage()
        {
            InitializeComponent();
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var attractionName = Uri.EscapeDataString(e.SelectedItem as string);

            var backRoute = Uri.EscapeDataString(
                $"{Shell.Current.CurrentState.Location.OriginalString}");

            await Shell.Current.GoToAsync($"//touristsite?showback=true&info={attractionName}&backroute={backRoute}");

            attractionList.SelectedItem = null;
        }
    }
}
