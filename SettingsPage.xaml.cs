namespace MauiApp2;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }
    private void GoToProfilePage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ProfilePage));
    }

    private void GoToHistoryPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HistoryPage));
    }

    private void GoToCartPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(CartPage));
    }

    private void GoToSettingPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(SettingsPage));
    }
}