using KTI_Testing__Mobile_.Resources.viewModels;

namespace MauiApp2;

public partial class MauiLoginPage : ContentPage
{
    public MauiLoginPage(LoginPageViewModel loginPageViewModel)
    {
        InitializeComponent();
        this.BindingContext = loginPageViewModel;
    }
}