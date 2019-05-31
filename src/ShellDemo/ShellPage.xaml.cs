using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellDemo
{
    public partial class ShellPage : Shell
    {
        public ShellPage()
        {
            InitializeComponent();

            BindingContext = this;

            Routing.RegisterRoute("busstop", typeof(BusStopPage));
        }

        protected override void OnNavigating(ShellNavigatingEventArgs args)
        {
            base.OnNavigating(args);
        }

        public Command AboutCommand
        {
            get => new Command(async () => await DisplayAlert("About", "Info here", "OK"));
        }
    }
}
