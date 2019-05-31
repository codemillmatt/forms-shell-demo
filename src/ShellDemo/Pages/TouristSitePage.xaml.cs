using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.ComponentModel;

namespace ShellDemo
{
    [QueryProperty("ShowBack", "showback")]
    [QueryProperty("BackRoute", "backroute")]
    [QueryProperty("TouristSiteInfo", "info")]
    public partial class TouristSitePage : ContentPage
    {
        public string ShowBack
        {
            set
            {
                ShowBackButton = bool.Parse(value);
            }
        }

        string touristSiteInfo = "Space Needle!";
        public string TouristSiteInfo
        {
            get => touristSiteInfo;
            set
            {
                touristSiteInfo = Uri.UnescapeDataString(value);
                OnPropertyChanged(nameof(TouristSiteInfo));
            }
        }

        bool showBackButton;
        public bool ShowBackButton
        {
            get => showBackButton;
            set
            {
                showBackButton = value;
                OnPropertyChanged(nameof(ShowBackButton));
            }
        }

        string backRoute;
        public string BackRoute
        {
            get => backRoute;
            set { backRoute = Uri.UnescapeDataString(value); }
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (ShowBackButton)
            {
                await Shell.Current.GoToAsync(BackRoute, true);
            }
        }

        public TouristSitePage()
        {
            InitializeComponent();

            BindingContext = this;
            ShowBackButton = false;
        }

        protected override void OnDisappearing()
        {
            ShowBackButton = false;
        }
    }
}
