namespace KTI_Testing__Mobile_.pages;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	private void goHome(object sender, EventArgs e)
	{
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }
}