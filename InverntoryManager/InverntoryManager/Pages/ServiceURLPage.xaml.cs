﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InverntoryManager.Pages
{
    public partial class ServiceURLPage : ContentPage
    {
        public ServiceURLPage()
        {
            InitializeComponent();
        }

        private async void SaveURL_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
            //Application.Current.MainPage = new LoginPage();
        }

        private async void Cancel_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
            //Application.Current.MainPage = new LoginPage();
        }
    }
}
