using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace KTI_Testing__Mobile_.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _userName;
        [ObservableProperty]
        private string _password;
    }
}
