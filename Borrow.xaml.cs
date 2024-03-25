namespace MauiApp2;
using KTI_Testing__Mobile_.Models;

public partial class Borrow : ContentPage
{
    public Borrow()
    {
        InitializeComponent();
    }

    private void cameraview_CamerasLoaded(object sender, EventArgs e)
    {
        if (cameraView.Cameras.Count > 0)
        {
            cameraView.Camera = cameraView.Cameras.First();
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                //Task.Delay(500);
                await cameraView.StopCameraAsync();
                await cameraView.StartCameraAsync();
            });
        }
    }

    private void cameraView_BarcodeDetected(object sender, Camera.MAUI.ZXingHelper.BarcodeEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            barcodeResult.Text = $"{args.Result[0].BarcodeFormat}: {args.Result[0].Text}";

            Tool myTool = new Tool(500, "kitty", "pooh", "haha", 100);

            //Navigation.PushAsync(new CartPage(myTool));
            await Shell.Current.GoToAsync($"{nameof(temp)}?adddedTool={myTool}");
        });
    }
}