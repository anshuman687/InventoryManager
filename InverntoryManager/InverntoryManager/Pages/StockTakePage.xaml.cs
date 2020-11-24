using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace InverntoryManager.Pages
{
    public partial class StockTakePage : ContentPage
    {
        public StockTakePage()
        {
            InitializeComponent();
        }
        private async void Qrscanner_Clicked(System.Object sender, System.EventArgs e)
        {
            ZXingScannerPage scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;
                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopAsync();

                });
            };
            await Navigation.PushAsync(scanPage);
        }
    }
}
