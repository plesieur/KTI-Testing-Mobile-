using KTI_Testing__Mobile_.pages;
using Camera.MAUI;
using Microsoft.Extensions.Logging;

namespace KTI_Testing__Mobile_
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void cameraview_CamerasLoaded(object sender, EventArgs e)
        {
            if (cameraView.Cameras.Count > 0)
            {
                cameraView.Camera = cameraView.Cameras.First();
                MainThread.BeginInvokeOnMainThread(async() =>
                {
                    //Task.Delay(500);
                    await cameraView.StopCameraAsync();
                    await cameraView.StartCameraAsync();
                });
            }
        }

        private void cameraView_BarcodeDetected(object sender, Camera.MAUI.ZXingHelper.BarcodeEventArgs args)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                barcodeResult.Text = $"{args.Result[0].BarcodeFormat}: {args.Result[0].Text}";
            });
        }

        private async void sendToPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private async void sendToPage2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new testPage());
        }
    }

}
