
namespace KTI_Testing__Mobile_.pages;
public partial class Login : ContentPage
{

	public Login()
	{
		InitializeComponent();
	}

    private async void homePage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}